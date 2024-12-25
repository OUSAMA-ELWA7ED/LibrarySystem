using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Models
{
    public class User_Borrow_Book
    {
        [BindProperty]
        public int BorrowId { get; set; }

        [BindProperty]
        public string? BorrowStatus { get; set; }

        [BindProperty]
        public int UserId { get; set; }

        [BindProperty]
        public int BookId { get; set; }

        [BindProperty]
        public DateTime BorrowDate { get; set; }

        [BindProperty]
        public DateTime DueDate { get; set; }
    }
}
