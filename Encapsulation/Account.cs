using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    //For example, you can declare a field as private to prevent it from being accessed directly from outside the class:
    public class Account
    {
        //Field Private
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }
    //In this example, the balance field is declared as private, and there are three public methods (Deposit, Withdraw, and GetBalance) that provide a way to access and modify the balance.
}
