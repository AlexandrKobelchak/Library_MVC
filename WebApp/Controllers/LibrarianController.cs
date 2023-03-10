using Entities.Library;
using Microsoft.AspNetCore.Mvc;
using Repositories.Abstract;

namespace WebApp.Controllers
{
    public class LibrarianController : Controller
    {
        private ILibrarianRepository _repository;
        public LibrarianController(ILibrarianRepository repository)
        {
            _repository = repository;
        }

        public IActionResult List()
        {
            return View(_repository.AllItems);
        }
        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Librarian? librarian)
        {
            if(librarian!=null)
            {
                await _repository.AddItemAsync(librarian);
            }
            return RedirectToAction("List");
        }
    }
}
