using System;
using System.Collections.Generic;
using System.Text;

namespace oop_week2_carpark
{
    class Garage
    {
        public Garage(string _name, int _availableSlots)
        {
            name = _name;
            availableSlots = _availableSlots;
        }

        public string name { get; set; }
        public double totalIncome { get; set; }
        public int availableSlots { get; set; }
        public List<Customer> customers { get; set; }

        public void updateCustomersTime()
        {
            foreach (Customer customer in customers)
            {
                if (customer.isParked)
                {
                    customer.hours++;
                }
            }
        }

        public void updateTotalIncomes()
        {
            totalIncome = 0;
            foreach (Customer customer in customers)
            {
                totalIncome += customer.price;
            }
        }

        public void printIncomes()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine(Program.ANSI_GREEN + "Total Garage's incomes: " + Program.ANSI_RESET + totalIncome);
        }
    }
}
