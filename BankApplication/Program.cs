using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int currentId = 0;
                UserCRUD userCRUD = new UserCRUD();
                //int option = 0;
                 userCRUD.AddUser(new User { UserId=101,UserName="admin",Password="admin101",ContactNo="2536495",RoleId=1});


                User user = new User();
                Console.WriteLine("Login.... ");
                Console.Write("Enter user Id");
                user.UserId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Password");
                user.Password = Console.ReadLine();
                int input = userCRUD.Login(user.UserId, user.Password);
                currentId = user.UserId;

                if (input == 0)
                {
                    Console.WriteLine("Invalid Entry");
                }
                else if (input == 1)
                {
                    Console.WriteLine("Welcome Admin");
                    Console.WriteLine("1: Add User");
                    Console.WriteLine("2: LogOut");
                    int op = Convert.ToInt32(Console.ReadLine());


                    switch (op)
                    {
                        /********* Add User *******/
                        case 1:
                            User u1 = new User();
                            Bank bank = new Bank();
                            Console.Write("Enter your user id:");
                            u1.UserId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Passward:");
                            u1.Password = Console.ReadLine();
                            Console.Write("Enter User Name:");
                            u1.UserName = Console.ReadLine();
                            Console.WriteLine("User Account No:");
                            bank.AccountNo = Convert.ToInt32(Console.ReadLine());
                            userCRUD.AddUser(u1);
                            break;
                        case 2:
                            break;
                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("Welcome User");
                    Console.WriteLine("1: Credit");
                    Console.WriteLine("2: Debit");
                    Console.WriteLine("3: View Balance");
                    Console.WriteLine("4: Account Details");
                    Console.WriteLine("5: Add Payee");
                    Console.WriteLine("6: Fund Transfer");
                    Console.WriteLine("7: Remove Payee");
                    Console.WriteLine("8: Log Out");
                    int op1 = Convert.ToInt32(Console.ReadLine());
                    switch (op1)
                    {
                        case 1:
                            BankCRUD crd = new BankCRUD();
                            crd.Credit(currentId, 1000, 500);
                            break;

                        case 2:
                            BankCRUD crd1 = new BankCRUD();
                            crd1.Debit(currentId, 1500, 200);
                            break;

                        case 3:
                            BankCRUD crd2 = new BankCRUD();
                            crd2.ViewBalance(currentId, 1300);
                            break;

                        case 4:
                            BankCRUD crd3 = new BankCRUD();
                            crd3.AccountDetails(currentId);
                            break;
                        case 5:

                            break;

                    }
                }
            }
        }
    }

