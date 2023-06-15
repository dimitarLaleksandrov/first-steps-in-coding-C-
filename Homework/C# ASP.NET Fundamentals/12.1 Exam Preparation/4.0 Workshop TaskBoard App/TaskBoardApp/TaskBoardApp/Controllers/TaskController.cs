using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Contracts;
using TaskBoardApp.Extensions;
using Microsoft.AspNetCore.Authorization;
using TaskBoardApp.ViewModels.Task;

namespace TaskBoardApp.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {
        private readonly IBoardServices boardService;

        private readonly ITaskServices taskService;

        public TaskController(ITaskServices taskServices, IBoardServices boardServices)
        {
            this.boardService = boardServices;
            this.taskService = taskServices;


        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            MyTaskFormModel viewModel = new MyTaskFormModel()
            {
                Boards = await this.boardService.AllForSelectAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MyTaskFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Boards = await this.boardService.AllForSelectAsync();

                return this.View(model);
            }

            bool boardExist = await this.boardService.ExistByIdAsync(model.BoardId);
            if (!boardExist)
            {

                ModelState.AddModelError(nameof(model.BoardId), "Selected board does not exist!");

                model.Boards = await this.boardService.AllForSelectAsync();

                return this.View(model);
            }

            string currentUserId = this.User.GetId();

            await this.taskService.AddAsync(currentUserId, model);

            return this.RedirectToAction("AllBoards", "Board");

        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                MyTaskDetailsViewModel viewModel = await this.taskService.GetForDetailsByIdAsync(id);

                return this.View(viewModel);
            }
            catch (Exception)
            {
                return this.RedirectToAction("AllBoards", "Board");

            }
        }
    }
}
