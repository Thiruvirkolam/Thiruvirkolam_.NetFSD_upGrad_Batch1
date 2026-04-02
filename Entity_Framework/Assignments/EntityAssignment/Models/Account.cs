using System;
using System.Collections.Generic;

namespace EntityAssignment.Models
{
    public class Account
    {
        public int AccountID {get; set;}
        public string? AccountType {get; set;}
        public string? Customer {get; set;}
        public decimal Balance {get; set;}
        public string? Branch {get; set;}
        public DateTime CreateDate {get; set;}
    }
}