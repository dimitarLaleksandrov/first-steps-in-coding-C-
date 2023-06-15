using Microsoft.AspNetCore.Mvc;
using TaskBoardApp.Contracts;
using TaskBoardApp.Data;

namespace TaskBoardApp.Controllers
{
    public class BoardController : Controller
    {

        private readonly IBoardServices boardServices;

        public BoardController(IBoardServices boardServices)
        {
            this.boardServices = boardServices;
        }

        [HttpGet]
        public async Task<IActionResult> AllBoards()
        {
            var boards = await boardServices.AllBoardsAsync();

            return View(boards);
        }
    }
}
