using Library.Contracts;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : BaseController
    {
        private readonly IBookServices bookServices;


        public BookController(IBookServices bookServices)
        {
            this.bookServices = bookServices;
        }

        public async Task<IActionResult >All()
        {

            var model  = await bookServices.GetAllBooksAsync();

            return View(model);
        }

        public async Task<IActionResult> Mine()
        {
            var model = await bookServices.GetMyBooksAsync(GetUserId());

            return View(model);
        }

        public async Task<IActionResult> AddToCollection(int id)
        {
            var book = await bookServices.GetBookByIdAsync(id);

            if (book == null)
            {
                return RedirectToAction(nameof(All));
            }

            var userId = GetUserId();
      
            await bookServices.AddBookToCollectionAsync(userId, book);

            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> RemoveFromCollection(int id)
        {
            var book = await bookServices.GetBookByIdAsync(id);

            if (book == null)
            {
                return RedirectToAction(nameof(All));
            }

            var userId = GetUserId();

            await bookServices.RemoveBookFromCollection(userId, book);

            return RedirectToAction(nameof(Mine));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = await bookServices.GetNewAddBookModelAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddBookViewModel model)
        {
            decimal raiting;

            if (!decimal.TryParse(model.Rating, out raiting) || raiting < 0 || raiting > 10)
            {
                ModelState.AddModelError(nameof(model.Rating), "Rating must be a number between 0 and 10.");

                return View(model);
            }



            if (!ModelState.IsValid)
            {
                return View(model);

            }

            await bookServices.AddBookAsync(model);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var book = await bookServices.GetBookByIdForEditAsync(id);

            if (book == null)
            {
                return RedirectToAction(nameof(All));
            }

            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AddBookViewModel model)
        {
            decimal raiting;

            if (!decimal.TryParse(model.Rating, out raiting) || raiting < 0 || raiting > 10)
            {
                ModelState.AddModelError(nameof(model.Rating), "Rating must be a number between 0 and 10.");

                return View(model);
            }

            if (!ModelState.IsValid)
            {
                return View(model);

            }

            await bookServices.EditBookAsync(id, model);

            return RedirectToAction(nameof(All));
        }

    }
}
