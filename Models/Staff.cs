using System.ComponentModel;

namespace Project.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public List<CheckoutHistory>? CheckouHistories { get; set; }
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
