using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_13___Exercitiu_Suplimentar.Classes
{
    class BankAccount
    {
        private Guid guidCode;
        private decimal balance = 0;

        public Guid Id { get; private set; }

        public BankAccount()
        {
            this.Id = Guid.NewGuid();
        }

        public void DepositAmount(decimal depositAmount)
        {
            this.balance += depositAmount;
        }
        public decimal WithdrawalAmount(decimal withdrawalAmount)
        {
            try
            {
                {
                    if (withdrawalAmount >= balance)
                    {
                        balance -= withdrawalAmount;
                        return withdrawalAmount;
                    }
                    throw new Exception("You have Insufficient Funds!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }
    }
}
