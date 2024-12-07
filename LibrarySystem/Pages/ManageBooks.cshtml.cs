using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace LibrarySystem.Pages
{
    public class ManageBooksModel : PageModel
    {
        public List<Book> Books { get; set; } = new List<Book>
        {
            new Book { Id = 1, Title = "Sample Book 1", Author = "Author 1", Genre = "Fiction", IsAvailable = true },
            new Book { Id = 2, Title = "Sample Book 2", Author = "Author 2", Genre = "Drama", IsAvailable = false }
        };

        public void OnGet()
        {
            
        }

        public IActionResult OnPostAddBook(string Title, string Author, string Genre, bool IsAvailable)
        {
            
            Books.Add(new Book
            {
                Id = Books.Count + 1,
                Title = Title,
                Author = Author,
                Genre = Genre,
                IsAvailable = IsAvailable
            });
            return RedirectToPage();
        }

        public IActionResult OnPostUpdateBook(int BookId, string UpdatedTitle, string UpdatedAuthor, string UpdatedGenre, bool IsAvailable)
        {
            
            var book = Books.Find(b => b.Id == BookId);
            if (book != null)
            {
                book.Title = UpdatedTitle;
                book.Author = UpdatedAuthor;
                book.Genre = UpdatedGenre;
                book.IsAvailable = IsAvailable;
            }
            return RedirectToPage();
        }

        public IActionResult OnPostDeleteBook(int BookId)
        {
            
            Books.RemoveAll(b => b.Id == BookId);
            return RedirectToPage();
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }
        public bool IsAvailable { get; set; }
    }
}
