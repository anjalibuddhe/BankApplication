﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
  
    public class Bank
    {
        public int AccountNo { get; set; }
        public double AccountBalance { get; set; }
        public double Amount { get; set; }

        public int UserId { get; set; }
        public string Password { get; set; }



    }

    public class BankCRUD
    {
        private List<Bank> banks;
        UserCRUD user = new UserCRUD();

        public BankCRUD()
        {
            banks = new List<Bank>();
            banks.Add(new Bank { UserId = 102 });
        }

        public void Credit(int userid, double balance, double amount)
        {

            List<User> users = user.GetUsers();
            foreach (User item in users)
            {
                
                if (item.UserId == userid)
                {
                    balance = balance + amount;
                    Console.WriteLine($"Successfuly credited amount:{amount},\nNew account balance is:{balance}");
                }

            }
        }

        public void Debit(int userid, double balance, double amount)
        {
            List<User> users = user.GetUsers();
            foreach (User item in users)
            {
                if (item.UserId == userid)
                {
                    if (amount > balance)
                    {
                        Console.WriteLine("Insufficient balance:");
                    }
                    else
                    {
                        balance = balance - amount;
                        if (balance == 0)
                        {
                            Console.WriteLine("Zero Balance");
                        }
                        else if (balance < 3000)
                        {
                            Console.WriteLine("Low balance");
                        }
                    }
                }
                Console.WriteLine($"Successfuly credited amount:{amount},\nNew account balance is:{balance}");
            }

        }

        public void ViewBalance(int userid, double balance)
        {
            List<User> users = user.GetUsers();

            foreach (User item in users)
            {
                if (item.UserId == userid)
                {
                    Console.WriteLine($"Account balance is:{balance}");

                }
            }

        }

        public void AccountDetails(int userid)
        {
            List<User> users = user.GetUsers();
            Bank bank = new Bank();
            foreach (User item in users)
            {
                if (item.UserId == userid)
                {
                    Console.WriteLine($"User Name:{item.UserName}\nUser Id:{item.UserId}\nAccount No{bank.AccountNo}\nAccount Balance:{bank.AccountBalance}");

                }
            }
        }

        public void AddPayee(int userid, string payeeName, int PayeeAccountNo)
        {
            List<User> users = user.GetUsers();
            foreach (User item in users)
            {
                if (item.UserId == userid)
                {
                    Console.WriteLine($"Add Payee Name:{payeeName}\nAdd Payee Account No:{PayeeAccountNo}");
                }
            }
        
        }

    }
}
