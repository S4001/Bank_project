using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankUI.tUsers
{
    public class tUserData
    {
        internal int id;
        public int AccountID { get; set; }
        public int AccountNumber { get; set; }
        public string AccountsHolderName { get; set; }
        public string AccountType { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}