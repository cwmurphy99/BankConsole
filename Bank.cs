using System;
using System.Collections.Generic;

namespace BankConsole51
{
    public class Bank
    {
        public string Name { get; set; }

        public List<Account> Accounts { get; set; }

        public void AddAccount()
        {
            string firstName = Prompt("First Name> ");
            string lastName = Prompt("Last Name> ");
            string email = Prompt("Email> ");
            string street = Prompt("Street> ");
            string apt = Prompt("Apt> ");
            string city = Prompt("City> ");
            string state = Prompt("State> ");
            string zip = Prompt("Zip> ");

            Account newAccount = new Account
            {
                AccountOwner = new Customer
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Address = new Address
                    {
                        Street = street,
                        Apt = apt,
                        City = city,
                        State = state,
                        Zip = zip
                    }
                },

                Transactions = new List<Transaction>()

            };

        }

        public string Prompt(string promptText)
        {
            Console.Write(promptText);
            string response = Console.ReadLine();
            Console.WriteLine();
            return response;
        }

    }
}