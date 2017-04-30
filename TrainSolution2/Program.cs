using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSolution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean loop = true;
            int balance = 100;

            while (loop)
            {
                Console.WriteLine("\nAccount");
                Console.WriteLine("=================");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("0. Exit");
                Console.Write("Select number : ");

                int answer = Int32.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 0:
                        Console.WriteLine(0);
                        loop = false;
                        break;
                    case 1: //deposit
                        Console.Write("\nEnter money to deposit : ");
                        int income = Int32.Parse(Console.ReadLine());
                        balance += income;
                        Console.Write("Account balance is : " + balance);
                        Console.Write("\nPress any key...");
                        Console.ReadLine();
                        break;
                    case 2: //withdraw
                        Console.Write("\nEnter money to withdraw : ");
                        int outcome = Int32.Parse(Console.ReadLine());

                        if ((balance - outcome) < 100)
                        {
                            Console.Write("Cannot withdraw becourse money will less 100");
                            Console.Write("\nPress any key...");
                            Console.ReadLine();
                        }
                        else
                        {
                            balance -= outcome;
                            Console.Write("Account balance is : " + balance);
                            Console.Write("\nPress any key...");
                            Console.ReadLine();
                        }


                        break;
                    case 3: //check Balance
                        Console.WriteLine("\nAccount balance is : " + balance);
                        Console.Write("Press any key...");
                        Console.ReadLine();
                        break;
                }

            }


        }
    }
}
