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
        [DisplayName("Book")]
        public Book? Book { get; set; }
        [DisplayName("Book")]
        public int? BookID { get; set; }
        [DisplayName("Member")]
        public Member? Member { get; set; }
        public int? MemberID { get; set; }
        [DisplayName("Staff")]
        public Staff? Staff { get; set; }
        public int? StaffID { get; set; }
    }
}
