﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class BankAccount
    {
        private static long counter;
        private long _accountNumber;
        private decimal _balance;
        public enum _AccountType
        {
            Debit = 1,
            Credit,
            Saving
        }
        private _AccountType _accountType;

        public BankAccount(long accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public BankAccount(_AccountType accountType)
        {
            AccountType = accountType;
        }

        public long AccountNumber
        { 
            get { return _accountNumber; } 
            set { _accountNumber = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public _AccountType AccountType
        { get { return _accountType;}
          set { _accountType = value; }
        }
    }
}