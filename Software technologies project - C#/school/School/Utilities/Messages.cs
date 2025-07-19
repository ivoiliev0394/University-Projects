using System;
using System.Collections.Generic;
using System.Text;

namespace School.Utilities
{
    public class Messages
    {
        public const string IdOrEGN = "Enter correct ID or EGN!";
        public const string sizeEGN = "EGN must be 10 symbols!";
        public const string doesntExist = "There is no such record!";
        public const string EGNExist = "There is record with the same EGN!";
        public static readonly string InvalidDate = "Invalid date! Please enter a valid format (e.g. 2000-12-31).";
        public static readonly string incorrectId = "Enter correct ID!";
        public static readonly string notDecimal = "Invalid decimal input.";
        public const string stExist = "There is no such student!"; 
        public const string tExist = "There is no such Teacher!";
    }
}