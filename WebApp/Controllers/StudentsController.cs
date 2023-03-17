using BL.Models;
using BL.Services;
using Context;
using Entities.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;

namespace WebApp.Controllers
{
    public class StudentsController : Controller
    {
        IServiceScopeFactory _factory;
        IStudentRepository _repository;

        public StudentsController(IServiceScopeFactory factory, IStudentRepository repository) 
        {
            _repository = repository;
            _factory = factory;
        }
        public async Task<IActionResult> Index()
        {
            using (var scope = _factory.CreateScope())
            {
                var service = scope.ServiceProvider.GetService<StudentVMService>();
                if (service == null) throw new NullReferenceException(nameof(service));
                return View(await service.GetAllStudens());
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(StudentVM student)
        {

            using (var scope = _factory.CreateScope())
            {
                var service = scope.ServiceProvider.GetService<StudentVMService>();
                if(service ==null) throw new NullReferenceException(nameof(service));
                await service.Add(student);
            }
            return RedirectToAction("Index");
        }
    }
}
