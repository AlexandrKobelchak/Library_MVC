using BL.Models;
using Context;
using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Abstract;

namespace BL.Services;

public class StudentVMService
{
    private IServiceScopeFactory _factory;

    public StudentVMService(IServiceScopeFactory factory)
    {
        _factory = factory;
    }

    public StudentVM Student2VM(Student? student)
    {
        using (var scope = _factory.CreateScope())
        {
            var context = scope.ServiceProvider.GetService<AppDbContext>();

            if (student == null) throw new ArgumentNullException(nameof(student));
            if (student.Group == null || student.Group.Faculty == null)
            {
                student = context?.Set<Student>().Include(x => x.Group).ThenInclude(x => x.Faculty).FirstOrDefault(x => x.Id == student.Id);
            }
            if (student == null) throw new NullReferenceException(nameof(student));
            return new StudentVM()
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                GroupName = student.Group?.Name,
                FacultyName = student?.Group?.Faculty?.Name
            };
        }
    }
    public Student VM2Student(StudentVM student)
    {
        using (var scope = _factory.CreateScope())
        {
            IStudentRepository? students = scope?.ServiceProvider?.GetService<IStudentRepository>();
            IGroupRepository? groups = scope?.ServiceProvider?.GetService<IGroupRepository>();

            if (students == null) throw new NullReferenceException(nameof(students));
            if (groups == null) throw new NullReferenceException(nameof(groups));

            Student s = new Student
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                GroupId = groups.AllItems.FirstOrDefault(x => x.Name == student.GroupName)?.Id ?? Guid.Empty
            };
            return s;
        }
    }

    private async Task<Student?> GetStudentByIdAsync(Guid id)
    {
        using (var scope = _factory.CreateScope())
        {
            IStudentRepository? repository = scope?.ServiceProvider?.GetService<IStudentRepository>();
            //var context = scope?.ServiceProvider.GetService<AppDbContext>();

            if (repository == null) throw new NullReferenceException(nameof(repository));
            //if (context==null) throw new NullReferenceException(nameof(context));

            return await repository.GetItemAsync(id);
        }
    }


    public async Task<bool> Add(StudentVM vm)
    {
        Student student = VM2Student(vm);

        using (var scope = _factory.CreateScope())
        {
            IStudentRepository? repository = scope?.ServiceProvider?.GetService<IStudentRepository>();

            if (repository == null) throw new NullReferenceException(nameof(repository));

            return await repository.AddItemAsync(student);
        }
    }


    public async Task<bool> Change(StudentVM vm)
    {
        using (var scope = _factory.CreateScope())
        {
            IStudentRepository? repository = scope?.ServiceProvider?.GetService<IStudentRepository>();
            if (repository == null) throw new NullReferenceException(nameof(repository));

            return await repository.UpdateItemAsync(VM2Student(vm));
        }
    }

    public async Task<IEnumerable<StudentVM>> GetAllStudens()
    {
        using (var scope = _factory.CreateScope())
        {
            IStudentRepository? repository = scope?.ServiceProvider?.GetService<IStudentRepository>();

            if (repository == null) throw new NullReferenceException(nameof(repository));

#pragma warning disable CS8602 // Dereference of a possibly null reference.

            return await (repository.AllItems as DbSet<Student>)
            .Include(x => x.Group)
            .ThenInclude(x => x.Faculty)
            .Select(x => new StudentVM
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                GroupName = x.Group.Name ?? string.Empty,
                FacultyName = x.Group.Faculty.Name ?? string.Empty,

            }).ToListAsync();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        }
    }
}

