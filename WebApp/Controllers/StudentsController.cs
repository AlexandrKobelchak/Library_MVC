using BL.Models;
using Entities.Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;

namespace WebApp.Controllers
{
    public class StudentsController : Controller
    {
        IStudentRepository _repository;
        public StudentsController(IStudentRepository repository) 
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await StudentVM.GetAllStudens(_repository));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(StudentVM student)
        {
            await student.Add(_repository);
            return RedirectToAction("Index");
        }
    }
}
