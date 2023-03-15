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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Librarian? librarian)
        {
            if (librarian != null)
            {
                await _repository.AddItemAsync(librarian);
            }
            return RedirectToAction("List");
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return RedirectToAction("List");
            }
            else return View(await _repository.GetItemAsync(id.Value));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("List");
            }
            else return View(await _repository.GetItemAsync(id.Value));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Librarian? librarian)
        {
            if (librarian != null)
            {
                await _repository.UpdateItemAsync(librarian);
            }
            return RedirectToAction("List");
        }
    }
        
}
