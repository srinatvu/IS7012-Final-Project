﻿namespace Project.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<CheckoutHistory>? CheckouHistories { get; set; }
    }
}
