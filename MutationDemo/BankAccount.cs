using System;
using System.Collections.Generic;
using System.Linq;

namespace MutationDemo
{
    public class BankAccount
    {

        private int _balance;
        private List<int> _transactions = new List<int>();

        public BankAccount(int openingBalance = 0)
        {
            this._balance = openingBalance;
            _transactions.Add(openingBalance);
        }

        public int Balance
        {
            get => _balance;
            private set => _balance = value;
        }

        public IEnumerable<int> AllTransactions => new List<int>(_transactions);
        public IEnumerable<int> AllSpending => new List<int>(_transactions).Where(item => item < 0);
        public IEnumerable<int> AllDeposits => new List<int>(_transactions).Where(item => item > 0);

        public void Spend (int amount)
        {
            if (amount == 0)
            {
                throw new ArgumentException("You can't spend 0");
            }
            _transactions.Add(-1 * amount);
            Balance -= amount;
        }

        public void Deposit (int amount)
        {
            if (amount == 0)
            {
                throw new ArgumentException("you can't deposit 0");
            }
            _transactions.Add(amount);
            Balance += amount;
        }

        public void Rob()
        {
            _balance = 0;
        }

        public bool Audit()
        {
            return _transactions.Sum() == _balance;
        }

    }
}
