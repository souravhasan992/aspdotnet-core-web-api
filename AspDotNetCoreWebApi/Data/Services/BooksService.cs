using AspDotNetCoreWebApi.Data.ViewModels;
using AspDotNetCoreWebApi.Models;

namespace AspDotNetCoreWebApi.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            this._context = context;
        }
        public void AddBook(VmBook book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Genre = book.Genre,
                CoverUrl = book.CoverUrl,
                DateAdded = book.DateAdded
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        
    }
}
