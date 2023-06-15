using Library.Models;

namespace Library.Contracts
{
    public interface IBookServices
    {
        Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync();

        Task<IEnumerable<AllBookViewModel>> GetMyBooksAsync(string userId);

        Task<BookViewModel?> GetBookByIdAsync(int id);

        Task AddBookToCollectionAsync(string userId, BookViewModel book);

        Task RemoveBookFromCollection(string userId, BookViewModel book);

        Task<AddBookViewModel> GetNewAddBookModelAsync();

        Task AddBookAsync(AddBookViewModel model);

        Task<AddBookViewModel?> GetBookByIdForEditAsync(int id);

        Task EditBookAsync(int id, AddBookViewModel model);
    }
}


