using Laborator_13___Exercitiu_Suplimentar.Classes;
using System;

namespace Laborator_13___Exercitiu_Suplimentar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suplimentar

            //Card - ul
            //Va avea propriul ID de tip guid si nu va mai contine id - ul bancii.

            //Contul
            //Va persista numarul de carduri emise.

            //Banca
            //La emiterea cardului 
            //• Va memora intr - un dictionar id-ul contului corespunzator fiecarui id al cardului.
            //• In cazul in care au fost emise deja doua carduri pentru cont - ul cerut, nu va mai fi emis un nou
            //card ci va fi aruncata o exceptie.

            //Metoda „Plateste” va primi ca parametru ID - ul cardului si inainte de a efectua plata va incerca
            //determinarea contului pe baza id-ului cardului
            //• Daca cardul nu poate fi gasit, va arunca o exceptie
            //• Daca contul nu poate fi gasit, va arunca o exceptie
            //Va avea o metoda „Connect”
            // • Va arunca o exceptie daca sunt mai mult de 3 conexiuni active.
            //• Va incrementa numarul de conexiuni active
            //• Va afisa un mesaj pe ecran, „Connected”
            //Va avea o metoda „Disconnect”
            //• Va decrementa numarul conexiunilor active
            //• Va afisa un mesaj pe ecran, „Disconnected”

            //Card - ul

            //Metoda GetCardData
            //Va returna ID - ul cardului.

            //Pos - ul
            //Va avea o metoda privata „Connect” care
            //• Va incerca de 2 ori conectarea la Banca.
            //• In cazul in care conectarea a esuat, va arunca o exceptie corespunzatoare
            //Metoda Connect va fi apelata dupa introducerea cardului.
            //Dupa efectuarea platii, Pos - ul se va deconecta de la banca.

            //Suplimentar

            Bank bank = new Bank();
            bank.IssueCard();
            Card card = new Card(Guid.NewGuid());
            card.InsertCard();
            bank.Connect();
            bank.Pay(card);
            card.ExtractCard();
            bank.Disconnect();

            //Suplimentar 2
            //Banca este unica la nivel de aplicatie. Cititi despre Singleton design pattern si folositi-l.

            BankSuplimentar2Singleton bank2 = BankSuplimentar2Singleton.getBankInstance;
            bank2.IssueCard();
            Card card2 = new Card(Guid.NewGuid());
            bank.Connect();
            bank.Pay(card2);
            card.ExtractCard();
            bank.Disconnect();
        }
    }
}
