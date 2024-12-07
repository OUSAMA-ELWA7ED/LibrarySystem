using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using LibrarySystem.Models;

namespace LibrarySystem.Pages
{
    public class ManageBooksModel : PageModel
    {
        public List<Book> Books { get; set; } = new List<Book>
        {
            new Book { Id = 1, Title = "Book_1", Author = "Author_1", Genre = "Fiction", IsAvailable = true },
            new Book { Id = 2, Title = "Book_2", Author = "Author_2", Genre = "Drama", IsAvailable = false },
            new Book { Id = 3, Title = "Book_3", Author = "Author_3", Genre = "Action", IsAvailable = true }
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
  
}
