using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskBoardApp.Services.Interfaces;
using TaskBoardApp.Web.ViewModels.Board;

namespace TaskBoardApp.Controllers
{
    [Authorize]  //!!!!!  /// (Roles = "the name of the roll") !!!!!
    public class BoardController : Controller
    {
        private readonly IBoardService boardService;

        public BoardController(IBoardService boardService)
        {
                this.boardService = boardService;
        }

        [HttpGet]
        ///[AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<BoardAllViewModel> allBoards = await this.boardService.AllAsync();

            return View(allBoards);
        }
    }
}
