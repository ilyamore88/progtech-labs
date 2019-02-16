using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    public enum AccountType { Checking, Deposit };

    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    };

    class Struct
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            Console.Write("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accType = AccountType.Checking;
            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Balance {0}", goldAccount.accBal);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
        }
    }
}
