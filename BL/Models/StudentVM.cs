using Context;
using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{


    public class StudentVM
    {
        

        static StudentVM()
        {

        }


        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? GroupName { get; set; }
        public string? FacultyName { get; set; }
        public StudentVM()
        {
        }
        public StudentVM(Student student)
        {
            Id = student.Id;
            FirstName = student.FirstName;
            LastName = student.LastName;
            GroupName = student?.Group?.Name;
            FacultyName = student?.Group?.Faculty?.Name;
        }
        private Student GetStudent(AppDbContext context)
        {
            return new Student
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Group = context.Set<Group>().FirstOrDefault(x => x.Name == this.GroupName)
            };
        }

        public async Task<bool> Add(IStudentRepository repository)
        {
            return await repository.AddItemAsync(GetStudent(repository.Context as AppDbContext));
        }
        public async Task<bool> Change(IStudentRepository repository)
        {
            return await repository.UpdateItemAsync(GetStudent(repository.Context as AppDbContext));
        }

        public async static Task<IEnumerable<StudentVM>> GetAllStudens(IStudentRepository repository)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return await (repository.AllItems as DbSet<Student>)?
                .Include(x => x.Group)
                .ThenInclude(x => x.Faculty)
                .Select(x => new StudentVM(x))
                .ToListAsync();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
