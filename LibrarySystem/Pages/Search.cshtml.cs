using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using LibrarySystem.Models;

namespace LibrarySystem.Pages
{
    public class SearchModel : PageModel
    {
        
        public List<LibrarySystem.Models.Book> Books { get; set; } = new List<LibrarySystem.Models.Book>
        {
            new LibrarySystem.Models.Book { Id = 1, Title = "Book A", Author = "Author A", Genre = "Fiction", Year = 2020, IsAvailable = true },
            new LibrarySystem.Models.Book { Id = 2, Title = "Book B", Author = "Author B", Genre = "Non-Fiction", Year = 2018, IsAvailable = false }
        };

        public List<LibrarySystem.Models.User> Users { get; set; } = new List<LibrarySystem.Models.User>
        {
            new LibrarySystem.Models.User { Id = 1, Name = "Mo Ali", Email = "mo@example.com", Phone = "1234567890" },
            new LibrarySystem.Models.User { Id = 2, Name = "Ali Mo", Email = "Ali@example.com", Phone = "0987654321" }
        };

        
        public List<LibrarySystem.Models.Book> BookSearchResults { get; set; } = new List<LibrarySystem.Models.Book>();
        public List<LibrarySystem.Models.User> UserSearchResults { get; set; } = new List<LibrarySystem.Models.User>();

        public void OnGet()
        {
            
            BookSearchResults = Books;
            UserSearchResults = Users;
        }

        public void OnGetSearchBooks(string Title, string Author, string Genre, int? Year)
        {
            BookSearchResults = Books
                .Where(b =>
                    (string.IsNullOrEmpty(Title) || b.Title.Contains(Title, System.StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(Author) || b.Author.Contains(Author, System.StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(Genre) || b.Genre.Contains(Genre, System.StringComparison.OrdinalIgnoreCase)) &&
                    (!Year.HasValue || b.Year == Year.Value)
                )
                .ToList();
        }

        public void OnGetSearchUsers(string Name, int? UserId)
        {
            UserSearchResults = Users
                .Where(u =>
                    (string.IsNullOrEmpty(Name) || u.Name.Contains(Name, System.StringComparison.OrdinalIgnoreCase)) &&
                    (!UserId.HasValue || u.Id == UserId.Value)
                )
                .ToList();
        }
    }
}

