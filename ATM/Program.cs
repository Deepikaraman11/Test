using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        //static void Main(string[] args)
        //{

        //    int correctPassword = 1104;
        //    int balance = 50000;
        //    Console.WriteLine("Enter your Password:");
        //    int Password = int.Parse(Console.ReadLine());

        //    if (Password == correctPassword)
        //    {
        //        Console.WriteLine("1.Check Balance:");
        //        Console.WriteLine("2.Withdraw cash:");
        //        Console.WriteLine("3.Deposit Cash");
        //        Console.WriteLine("4.Fund Transfer");
        //        Console.WriteLine("5.Exit");
        //        Console.WriteLine("Enter Your Choice:");
        //        int choice = int.Parse(Console.ReadLine());


        //       switch (choice)
        //        {
        //            case 1:
        //                Console.WriteLine("Enter your password: ");
        //                int enteredPassword = int.Parse(Console.ReadLine());

        //                if (enteredPassword == correctPassword)
        //                {
        //                    Console.WriteLine("Your account balance is:" + balance);
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Incorrect password");
        //                }

        //                break;
        //            case 2:
        //                int withdraw;

        //                Console.WriteLine("Enter your password: ");
        //                int enterPassword = int.Parse(Console.ReadLine());

        //                if (enterPassword == correctPassword)
        //                {
        //                    Console.WriteLine("Access granted!");
        //                    Console.WriteLine("Enter Withdrawal Amount:");


        //                    withdraw = int.Parse(Console.ReadLine());
        //                    if (withdraw>=500 && withdraw<=10000 && withdraw<=(balance-500))
        //                    {
        //                        balance -= withdraw;
        //                        Console.WriteLine("Withdrawal Successful New Balance:" + balance);
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Insufficient Funds.");
        //                    }
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Incorrect password.");
        //                }
        //                break;

        //            case 3:

        //                int deposit;
        //                Console.Write("Enter your password: ");
        //                int entersPassword = int.Parse(Console.ReadLine());
        //                if (entersPassword == correctPassword)
        //                {
        //                    Console.WriteLine("Access granted");
        //                    Console.Write("Enter Deposit Amount: ");

        //                    deposit = int.Parse(Console.ReadLine());
        //                    if (deposit > 0)
        //                    {
        //                        balance += deposit;
        //                        Console.WriteLine("Deposit Successful! New Balance: " + balance);
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Invalid Deposit Amount.");
        //                    }
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Incorrect password");
        //                }
        //                break;

        //            case 4:

        //                int transfer;
        //                Console.Write("Enter your password: ");
        //                int enterssPassword = int.Parse(Console.ReadLine());
        //                if (enterssPassword == correctPassword)
        //                {
        //                    Console.WriteLine("Access granted!");
        //                    Console.Write("Enter Transfer Amount: ");

        //                    transfer = int.Parse(Console.ReadLine());
        //                    if (transfer > 0 && transfer <= balance)
        //                    {
        //                        balance -= transfer;
        //                        Console.WriteLine("Fund Transfer Successful! New Balance: " + balance);
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Insufficient Balance.");
        //                    }
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Incorrect password");
        //                }
        //                break;

        //            case 5:
        //                Console.WriteLine("Exit");
        //                return;

        //            default:
        //                Console.WriteLine("Invalid Choice");
        //                break;
        //        }   
        //    }
        //    else
        //    {
        //        Console.WriteLine("Incorrect Password");
        //    }

        //}




        //ATM Using Function
        static int password = 1104;
        static int balance = 50000;
       static int deposit;
        static int transfer;



        public static void Fun()
        {
            Console.WriteLine("Enter Your Password :");
            int psd = int.Parse(Console.ReadLine());
            if(password==psd)
            {
                Console.WriteLine("1.Check Balance:");
                Console.WriteLine("2.Withdraw cash:");
                Console.WriteLine("3.Deposit Cash");
                Console.WriteLine("4.Fund Transfer");
                Console.WriteLine("5.Exit");

                Console.WriteLine("Enter Your Choice:");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Balance();
                        break;
                    case 2:
                        Withdraw();                        
                        break;
                    case 3:
                        Deposit();
                        break;
                    case 4:
                        Transfer();
                        break;
                    case 5:
                        Exit();
                        break;
                    
                }

            }

         }
        public static void Balance()
        {
            Console.WriteLine("Enter your password: ");
            int psd = int.Parse(Console.ReadLine());

            if (psd == password)
            {
                Console.WriteLine("Your account balance is:" + balance);
            }
            else
            {
                Console.WriteLine("Incorrect password");
            }

        }
        public static void Withdraw()
        {

            Console.WriteLine("Enter Your Password :");
            int psd = int.Parse(Console.ReadLine());

            if (psd == password)
            {
                Console.WriteLine("Access granted!");
                Console.WriteLine("Enter Withdrawal Amount:");


                int withdraw = int.Parse(Console.ReadLine());
                if (withdraw >= 500 && withdraw <= balance - 500)
                {
                    balance -= withdraw;
                    Console.WriteLine("Withdrawal Successful New Balance:" + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient Funds.");
                }
            }
        }
        public static void Deposit()
        {
            Console.WriteLine("Enter your password: ");
            int psd = int.Parse(Console.ReadLine());
            if (psd == password)
                
            {
                Console.WriteLine("Access granted");
                Console.Write("Enter Deposit Amount: ");

                deposit = int.Parse(Console.ReadLine());
                if (deposit > 0)
                {
                    balance += deposit;
                    Console.WriteLine("Deposit Successful! New Balance: " + balance);
                }
                else
                {
                    Console.WriteLine("Invalid Deposit Amount.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect password");
            }
        }

        public static void Transfer()
        {

            Console.WriteLine("Enter Your Password :");
            int psd = int.Parse(Console.ReadLine());

            if (psd == password)
            {
                Console.WriteLine("Access granted!");
                Console.Write("Enter Transfer Amount: ");

                transfer = int.Parse(Console.ReadLine());
                if (transfer > 0 && transfer <= balance)
                {
                    balance -= transfer;
                    Console.WriteLine("Fund Transfer Successful! New Balance: " + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient Balance.");
                }
            }
            else
            {
                Console.WriteLine("Incorrect password");
            }
        }

        public static void Exit()
        {
            
            Console.WriteLine("Exit");
                

        }
        public static void Main()
        {
            Fun();
        }

    }

}

