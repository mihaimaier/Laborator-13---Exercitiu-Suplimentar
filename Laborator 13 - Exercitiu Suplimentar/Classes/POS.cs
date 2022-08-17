using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_13___Exercitiu_Suplimentar.Classes
{
    class POS
    {
        public Guid Id { get; private set; }
        static bool Connected = true;

        public void Pay(decimal amount, Card card)
        {
            card.InsertCard();
            card.GetCardData(Id);
            card.Pay();
            card.ExtractCard();
        }
        private void Connect()
        {
            try
            {
                Card card = new Card(Id);
                card.InsertCard();
                Bank bank = new Bank();
                Connected = true;
                bank.Connect();
                Connected = true;
                if (Connected == false)
                {
                    bank.Disconnect();
                    throw new Exception("Unfortuantely we are having issues connecting to the bank! Please retry");
                }
                bank.Pay(card);
                bank.Disconnect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
