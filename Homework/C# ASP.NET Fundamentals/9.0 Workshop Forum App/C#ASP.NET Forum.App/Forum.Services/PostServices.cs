using Forum.App.Data;
using Forum.Data.Mode;
using Forum.Services.Interfaces;
using Forum.ViewModel.Post;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Services
{
    public class PostServices : IPostService
    {
        private readonly ForumDbContext dbContext;
        public PostServices(ForumDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddPostAsync(PostAddFormModel postViewModel)
        {
            {
                Post newPost = new Post()
                {
                    Title = postViewModel.Title,
                    Content = postViewModel.Content,
                };
                await this.dbContext.Posts.AddAsync(newPost);
                await this.dbContext.SaveChangesAsync();
        }
        }

        public async Task DeleteByIdAsync(string id)
        {
            var postToDelete = await this.dbContext
                .Posts
                .FirstAsync(p => p.Id.ToString().ToLower() == id.ToLower());

            this.dbContext.Posts.Remove(postToDelete);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditByIdAsync(string id, PostAddFormModel postEditModel)
        {
            var postToEdit = await this.dbContext
                .Posts
                .FirstAsync(p => p.Id.ToString().ToLower() == id.ToLower());
            postToEdit.Title = postEditModel.Title;
            postToEdit.Content = postEditModel.Content;

            await this.dbContext.SaveChangesAsync();

        }

        public async Task<PostAddFormModel> GetForEditOrDeleteByIdAsync(string id)
        {
            var postEdit = await this.dbContext
                .Posts
                .FirstAsync(p => p.Id.ToString().ToLower() == id.ToLower());

            return new PostAddFormModel() 
            { 
                Title = postEdit.Title, 
                Content = postEdit.Content 
            };

        }

        public async Task<IEnumerable<PostListViewModel>> ListAllAsync()
        {
            IEnumerable<PostListViewModel> allPosts = await dbContext
                .Posts
                .Select(p => new PostListViewModel() 
                {
                    Id = p.Id.ToString(),
                    Title = p.Title,
                    Content = p.Content,
                })
                .ToArrayAsync();
            return allPosts;
        }

           
    }
}
