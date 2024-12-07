using Microsoft.AspNetCore.Mvc.RazorPages;
using LibrarySystem.Models; 
using System.Collections.Generic;

namespace LibrarySystem.Pages
{
    public class BooksModel : PageModel
    {
        public List<Book> AllBooks { get; set; } = new List<Book>();

        public void OnGet()
        {
            
            AllBooks = new List<Book>
            {
                new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", IsAvailable = true },
                new Book { Id = 2, Title = "1984", Author = "George Orwell", Genre = "Dystopian", IsAvailable = true },
                new Book { Id = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic", IsAvailable = true },
                new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", IsAvailable = false },
                new Book { Id = 5, Title = "Moby Dick", Author = "Herman Melville", Genre = "Adventure", IsAvailable = true }
            };
        }
    }
}
