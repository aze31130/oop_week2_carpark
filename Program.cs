using System;
using System.Collections.Generic;
using System.Threading;

namespace oop_week2_carpark
{
    class Program
    {
        public static int CustomerAmount = 5;
        public static string ANSI_GREEN = "\u001b[32m";
        public static string ANSI_CYAN = "\u001b[36m";
        public static string ANSI_RESET = "\u001b[0m";
        static void Main(string[] args)
        {
            //Create the garage
            Garage garage = new Garage("The best Garage", 5);

            //Create all customers
            List<Customer> customers = new List<Customer>(CustomerAmount) { };
            String[] names = {"Victor","Michel","Kim","Jean","Michael"};
            int[] enteredHour = { 2, 15, 7, 9, 20 };
            
            for (int i = 0; i < CustomerAmount; i++)
            {
                customers.Add(new Customer(i, names[i], enteredHour[i]));
            }
            garage.customers = customers;

            //Main loop to simulate the time
            for (int hours = 0; hours < 25; hours++)
            {
                if (hours < 13)
                {
                    Console.WriteLine("Hour: " + hours + " AM");
                }
                else
                {
                    Console.WriteLine("Hour: " + (hours - 12) + " PM");
                }

                //Park customers and update the price
                foreach (Customer customer in garage.customers)
                {
                    if (customer.enteredHour == hours)
                    {
                        customer.park();
                        Console.WriteLine("[" + ANSI_GREEN + "INFO"+ ANSI_RESET + "] " + customer.name + " just parked !");
                    }
                    
                    customer.calculateCharges();
                    garage.updateTotalIncomes();
                }
                garage.updateCustomersTime();
                //To simulate the hours and have time to see how evolves the clients
                Thread.Sleep(200);
            }
            garage.printIncomes();
        }
    }
}
