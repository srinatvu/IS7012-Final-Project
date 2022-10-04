using System.ComponentModel;

namespace Project.Models
{
    public class Member
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [DisplayName("Email Address")]
        public string Email { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DOB { get; set; }
        [DisplayName("Address")]
        public string Address { get; set; }
        [DisplayName("Books")]
        public List<Book>? Books { get; set; }
        [DisplayName("Checkout Information")]
        public List<CheckoutHistory>? CheckoutHistories { get; set; }
        [DisplayName("Full Name")]
        public string FullName
        {
            get
            {      // CONCAT FIRST & LAST NAME
                return $"{FirstName} {LastName}";
            }
        }
    }
}
