using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Models
{
    public class Book
    {
        [BindProperty]
        public int Id { get; set; } 

        [BindProperty]
        public string Name { get; set; } 

        [BindProperty]
        public int AvailableCopies { get; set; } 

        [BindProperty]
        public string? Publisher { get; set; }

        [BindProperty]
        public int LocationId { get; set; } 

        [BindProperty]
        public int AuthorId { get; set; } 

        [BindProperty]
        public int? CategoryId { get; set; } 
    }
}
