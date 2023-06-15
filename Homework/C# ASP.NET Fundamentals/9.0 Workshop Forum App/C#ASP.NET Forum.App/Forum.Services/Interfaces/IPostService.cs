using Forum.Data.Mode;
using Forum.ViewModel.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Services.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostListViewModel>> ListAllAsync();

        Task AddPostAsync(PostAddFormModel postViewModel);

        Task<PostAddFormModel> GetForEditOrDeleteByIdAsync(string id);

        Task EditByIdAsync(string id, PostAddFormModel postEditModel);

        Task DeleteByIdAsync(string id);

    }
}
