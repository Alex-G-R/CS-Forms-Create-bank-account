using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Account
    {
        public string Number { get; }
        public string OwnerName { get; set; }
        public string OwnerSurname { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }


        private static int accountNumberSeed = 0000000000;


        public Account(string ownerName, string ownerSurname, string password, decimal balance)
        {
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            OwnerName = ownerName;
            OwnerSurname = ownerSurname;
            Password = password;
            Balance = balance;

        }
    }
}
