using System.ComponentModel;

namespace Project.Models
{
    public class Author
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Gender")]
        public string gender { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DOB { get; set; }
        [DisplayName("Books")]
        public List<Book>? Books { get; set; }
        public string FullName
        {
            get
            {      // CONCAT FIRST & LAST NAME
                return $"{FirstName} {LastName}";
            }
        }
    }
}
