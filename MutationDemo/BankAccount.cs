using System;
using System.Collections.Generic;

namespace MutationDemo
{
    public class BankAccount
    {

        private int _balance;

        public int Balance
        {
            get => _balance;
            private set => _balance = value;
        }

        private List<int> _transactions = new List<int>();

        public BankAccount(int openingBalance = 0)
        {
            this._balance = openingBalance;
        }

        public void Spend (int amount)
        {
            if (amount == 0)
            {
                new ArgumentException("You can't spend 0");
            }
            _transactions.Add(-1 * amount);
            Balance += amount;
        }

    }
}
