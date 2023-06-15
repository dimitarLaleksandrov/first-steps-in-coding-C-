using Forum.Services.Interfaces;
using Forum.ViewModel.Post;
using Microsoft.AspNetCore.Mvc;

namespace Forum.App.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<PostListViewModel> allPosts = await this.postService.ListAllAsync();
            return View(allPosts);
        } 

        public IActionResult Add() 
        { 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostAddFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await this.postService.AddPostAsync(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occurre while adding your post!");
                return View(model);
            }

            return RedirectToAction("All", "Post");
        }

        public async Task<IActionResult> Edit(string id) 
        {
            try
            {
                var postModel = await this.postService.GetForEditOrDeleteByIdAsync(id);
                return View(postModel);
            }
            catch (Exception)
            {
                return this.RedirectToAction("All", "Post");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, PostAddFormModel postModel)
        {
            if (!ModelState.IsValid)
            {
                return this.View(postModel);
            }
            try
            {
               await this.postService.EditByIdAsync(id, postModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occurre while updating your post!");
                return View(postModel);
            }

            return RedirectToAction("All", "Post");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
               await this.postService.DeleteByIdAsync(id);
            }
            catch (Exception)
            {
                

            }
            return this.RedirectToAction("All", "Post");
        }
    }
}
