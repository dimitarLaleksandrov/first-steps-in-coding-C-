﻿using Library.Contracts;
using Library.Data;
using Library.Data.Models;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public class BookService : IBookServices
    {
        private readonly LibraryDbContext dbContext;

        public BookService(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddBookAsync(AddBookViewModel model)
        {

            Book book = new Book
            {
                Title = model.Title,
                Author = model.Author,
                ImageUrl = model.Url,
                Description = model.Description,
                CategoryId = model.CategoryId,
                Rating = decimal.Parse(model.Rating)
            };

            await dbContext.Books.AddAsync(book);

            await dbContext.SaveChangesAsync();
        }

        public async Task AddBookToCollectionAsync(string userId, BookViewModel book)
        {
            var userBook = new IdentityUserBook
            {
                CollectorId = userId,
                BookId = book.Id,
            };

            await dbContext.IdentityUserBook.AddAsync(userBook);
            await dbContext.SaveChangesAsync();


            //bool alreadyAdded = await dbContext.IdentityUserBook.AnyAsync(x => x.CollectorId == userId && x.BookId == book.Id);

            //if (!alreadyAdded)
            //{
                
            //}
          
        }

        public async Task EditBookAsync(int id, AddBookViewModel model)
        {
            var book = await dbContext.Books.FindAsync(id);

            if (book != null)
            {
                book.Title = model.Title;
                book.Author = model.Author;
                book.ImageUrl = model.Url;
                book.Description = model.Description;
                book.CategoryId = model.CategoryId;
                book.Rating = decimal.Parse(model.Rating);

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<AllBookViewModel>> GetAllBooksAsync()
        {
            return await this.dbContext
                 .Books
                 .Select(b => new AllBookViewModel
                 {
                     Id = b.Id,
                     Title = b.Title,
                     Author = b.Author,
                     ImageUrl = b.ImageUrl,
                     Rating = b.Rating,
                     Category = b.Category.Name
                     
                 })
                 .ToListAsync();

        }

        public async Task<BookViewModel?> GetBookByIdAsync(int id)
        {
            return await dbContext.Books
                 .Where(x => x.Id == id)
                 .Select(b => new BookViewModel
                 {
                     Id = b.Id,
                     Title = b.Title,
                     Author = b.Author,
                     ImageUrl = b.ImageUrl,
                     Description = b.Description,
                     Rating = b.Rating,
                     CategoryId = b.CategoryId

                 })
                 .FirstOrDefaultAsync();
        }

        public async Task<AddBookViewModel?> GetBookByIdForEditAsync(int id)
        {
            var categories = await dbContext.Categorys
                                    .Select(x => new CategoryViewModel
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                    })
                                    .ToListAsync();
            return await dbContext.Books
                 .Where(x => x.Id == id)
                 .Select(b => new AddBookViewModel
                 {
                     
                     Title = b.Title,
                     Author = b.Author,
                     Url = b.ImageUrl,
                     Description = b.Description,
                     Rating = b.Rating.ToString(),
                     CategoryId = b.CategoryId,
                     Categories = categories
                 })
                 .FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<AllBookViewModel>> GetMyBooksAsync(string userId)
        {
            return await dbContext.IdentityUserBook
                 .Where(x => x.CollectorId == userId)
                 .Select(b => new AllBookViewModel
                 {
                     Id = b.Book.Id,
                     Title = b.Book.Title,
                     Author = b.Book.Author,
                     ImageUrl = b.Book.ImageUrl,
                     Description = b.Book.Description,
                     Category = b.Book.Category.Name
                 })
                 .ToArrayAsync();

        }

        public async Task<AddBookViewModel> GetNewAddBookModelAsync()
        {
            var categories = await dbContext.Categorys
                                    .Select(x => new CategoryViewModel
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                    })
                                    .ToListAsync();

            var model = new AddBookViewModel 
            { 
                Categories = categories
            };

            return model;

        }

        public async Task RemoveBookFromCollection(string userId, BookViewModel book)
        {

            var userBook = await dbContext.IdentityUserBook.FirstOrDefaultAsync(x => x.CollectorId == userId && x.BookId == book.Id);

            if (userBook != null)
            {
                dbContext.IdentityUserBook.Remove(userBook);
                await dbContext.SaveChangesAsync();
            }

        }
    }
}
