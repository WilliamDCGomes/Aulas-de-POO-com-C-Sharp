﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities {
    class Business_Account : Account {
        public double LoanLimit { get; set; }

        public Business_Account() {
        }
        public Business_Account(int number, string holder, double balance, double loanLimit):base(number,holder,balance) {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
        }
    }
}
