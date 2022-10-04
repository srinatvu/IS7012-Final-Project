using System.ComponentModel;

namespace Project.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        [DisplayName("Book Availability")]
        public bool IsAvailable { get; set; }
        public Member? Member { get; set; }
        public int? MemberID { get; set; }
        public List<CheckoutHistory>? CheckoutHistories { get; set; }
        public Author? Author { get; set; }
        public int? AuthorId { get; set; }

    }
}
