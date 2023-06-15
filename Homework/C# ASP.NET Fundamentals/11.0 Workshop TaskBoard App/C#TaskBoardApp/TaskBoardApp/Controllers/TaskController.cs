using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data;
using TaskBoardApp.Extensions;
using TaskBoardApp.Services.Interfaces;
using TaskBoardApp.Web.ViewModels.Board;
using TaskBoardApp.Web.ViewModels.Task;

namespace TaskBoardApp.Controllers
{
    [Authorize]
    public class TaskController : Controller
    {

        private readonly IBoardService boardService;

        private readonly ITaskService taskService;

        public TaskController(IBoardService boardService, ITaskService taskService)
        {
            this.boardService = boardService;
            this.taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            TaskFormModel viewModel = new TaskFormModel()
            {
                AllBoards = await this.boardService.AllForSelectAsync()
            };


            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskFormModel model)
        {
            if (!ModelState.IsValid) 
            {
                model.AllBoards = await this.boardService.AllForSelectAsync();

                return this.View(model);
            }

            bool boardExist = await this.boardService.ExistByIdAsync(model.BoardId);
            if (!boardExist)
            {             
                
                ModelState.AddModelError(nameof(model.BoardId), "Selected board does not exist!");

                model.AllBoards = await this.boardService.AllForSelectAsync();

                return this.View(model);
            }

            string currentUserId = this.User.GetId();

            await this.taskService.AddAsync(currentUserId, model);

            return this.RedirectToAction("All", "Board");

        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                TaskDetailsViewModel viewModel = await this.taskService.GetForDetailsByIdAsync(id);

                return this.View(viewModel);
            }
            catch (Exception)
            {
                return this.RedirectToAction("All", "Board");
                
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var task = await taskService.GetForEditByIdAsync(id.ToString());
            if (task == null)
            {
                return BadRequest();
            }
            string currentUserId = this.User.GetId();

            TaskFormModel taskModel =  new TaskFormModel()
            {
                Title = task.Title,
                Description = task.Description,
                BoardId = task.BoardId,
                AllBoards =  task.AllBoards      
            };

            return this.View(taskModel);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, TaskFormModel taskModel)
        {
            var task = await this.taskService.GetForEditByIdAsync(id.ToString());

            if (!ModelState.IsValid)
              {
                  taskModel.AllBoards = await this.boardService.AllForSelectAsync();
    
                  return this.View(taskModel);
              }
    
              bool boardExist = await this.boardService.ExistByIdAsync(taskModel.BoardId);
    
             if (!boardExist)
              {
    
                  ModelState.AddModelError(nameof(taskModel.BoardId), "Selected board does not exist!");
    
                  taskModel.AllBoards = await this.boardService.AllForSelectAsync();
    
                  return this.View(taskModel);
              }
    
              string currentUserId = this.User.GetId();

            task.Title = taskModel.Title;
            task.Description = taskModel.Description;
            task.BoardId = taskModel.BoardId;

                  
              return this.RedirectToAction("All", "Board");
   
        }
    }
}
