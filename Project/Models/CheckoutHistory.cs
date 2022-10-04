using System.ComponentModel;

namespace Project.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }
        [DisplayName("Date Borrowed")]
        public DateTime BorrowDate { get; set; }
        [DisplayName("Date Returned")]
        public DateTime ReturnDate { get; set; }
        public Book? Book { get; set; }
        public int? BookID { get; set; }
        public Member? Member { get; set; }
        public int? MemberID { get; set; }
        public Staff? Staff { get; set; }
        public int? StaffID { get; set; }
    }
}
