using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages
{
    public class TrackBorrowingsModel : PageModel
    {
        public List<BorrowingRecord> BorrowingRecords { get; set; } = new List<BorrowingRecord>
        {
            new BorrowingRecord { RecordId = 1, BookTitle = "Book 1", MemberName = "John Doe", Action = "Borrow", Date = DateTime.Now.AddDays(-3) },
            new BorrowingRecord { RecordId = 2, BookTitle = "Book 2", MemberName = "Jane Smith", Action = "Return", Date = DateTime.Now.AddDays(-1) }
        };

        public List<BookStatistic> MostBorrowedBooks { get; set; } = new List<BookStatistic>
        {
            new BookStatistic { Title = "Book 1", TimesBorrowed = 15 },
            new BookStatistic { Title = "Book 3", TimesBorrowed = 12 }
        };

        public List<BookStatistic> LeastBorrowedBooks { get; set; } = new List<BookStatistic>
        {
            new BookStatistic { Title = "Book 5", TimesBorrowed = 2 },
            new BookStatistic { Title = "Book 6", TimesBorrowed = 1 }
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
