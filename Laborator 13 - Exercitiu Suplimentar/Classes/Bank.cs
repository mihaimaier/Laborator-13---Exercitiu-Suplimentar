using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_13___Exercitiu_Suplimentar.Classes
{
    class Bank
    {
        public Dictionary<Guid, BankAccount> BankAccounts { get; private set; }
        public Guid Id { get; private set; }

        public Bank()
        {
            this.BankAccounts = CreateAccount();
        }

        private Dictionary<Guid, BankAccount> CreateAccount()
        {
            Dictionary<Guid, BankAccount> accounts = new Dictionary<Guid, BankAccount>();
            accounts.Add(Id, new BankAccount());
            return accounts;
        }
        public void IssueCard()
        {
            Dictionary<Guid, BankAccount> accounts = new Dictionary<Guid, BankAccount>();
            accounts.Add(Id, new BankAccount());
            try
            {
                if (accounts.ContainsKey(Id))
                {
                    throw new Exception($"Cannot issue card! The card with the {Id} already exists");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void Pay(Card card)
        {
            try
            {
                if (card.Id == null)
                {
                    throw new Exception("Bank Account does not exist!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void Connect()
        {
            int activeConnections = 0;
            try
            {
                Connect();
                {
                    Console.WriteLine("Connected");
                    activeConnections++;
                }
                if (activeConnections > 3)
                {
                    throw new Exception("Cannot connect anymore! Exceeds the amount of connections!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Disconnect();
                {
                    Console.WriteLine("Disconnected");
                    activeConnections--;
                }
            }
        }
        public void Disconnect()
        {
        }
    }
}