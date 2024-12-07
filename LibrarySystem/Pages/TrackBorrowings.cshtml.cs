using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages
{
    public class TrackBorrowingsModel : PageModel
    {
        public List<BorrowingRecord> BorrowingRecords { get; set; } = new List<BorrowingRecord>
        {
            new BorrowingRecord { RecordId = 1, BookTitle = "Book_1", MemberName = "Mo Ali", Action = "Borrow", Date = DateTime.Now },
            new BorrowingRecord { RecordId = 2, BookTitle = "Book_2", MemberName = "Moustafa Mohamed", Action = "Return", Date = DateTime.Now }
        };

        public List<BookStatistic> MostBorrowedBooks { get; set; } = new List<BookStatistic>
        {
            new BookStatistic { Title = "Book_1", TimesBorrowed = 15 },
            new BookStatistic { Title = "Book_3", TimesBorrowed = 12 }
        };

        public List<BookStatistic> LeastBorrowedBooks { get; set; } = new List<BookStatistic>
        {
            new BookStatistic { Title = "Book_5", TimesBorrowed = 2 },
            new BookStatistic { Title = "Book_6", TimesBorrowed = 1 }
        };

        public IActionResult OnPostRecordBorrowing(int BookId, int MemberId, string ActionType)
        {
         
            return RedirectToPage();
        }
    }

    public class BorrowingRecord
    {
        public int RecordId { get; set; }
        public string BookTitle { get; set; }
        public string MemberName { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
    }

    public class BookStatistic
    {
        public string Title { get; set; }
        public int TimesBorrowed { get; set; }
    }
}
