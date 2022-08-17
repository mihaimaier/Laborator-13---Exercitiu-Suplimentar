using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_13___Exercitiu_Suplimentar.Classes
{
    class Card
    {

        public Guid Id { get; private set; }

        public Card(Guid id)
        {
            this.Id = id;
        }
        public void InsertCard()
        {
            Console.WriteLine("Please insert your card!");
        }
        public Guid GetCardData(Guid id)
        {
            return id;
        }
        public void ExtractCard()
        {
            Console.WriteLine("Please remove your card!");
        }
    }
}