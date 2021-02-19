using System;
using System.Collections.Generic;
using System.Text;

namespace oop_week2_carpark
{
    class Customer
    {

        public Customer(int _id, string _name, int _enteredHour)
        {
            id = _id;
            name = _name;
            hours = 0;
            enteredHour = _enteredHour;
            price = 0;
            isParked = false;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int hours { get; set; }
        public int enteredHour { get; set; }
        public double price { get; set; }
        public bool isParked { get; set; }

        public void calculateCharges()
        {
            if (isParked)
            {
                if (hours > 0)
                {
                    price = 2;
                }
                int temp = 3;
                while (hours > temp)
                {
                    price += 0.5;
                    temp++;
                }

                if (price > 10)
                {
                    price = 10;
                }
            }
        }

        public void park()
        {
            isParked = true;
        }

        public override string ToString()
        {
            String prettyPrint = @"══════════════════════════════════" + "\n"
                + Program.ANSI_CYAN + "Id: " + Program.ANSI_RESET + id + "\n"
                + Program.ANSI_CYAN + "Name: " + Program.ANSI_RESET + name + "\n"
                + Program.ANSI_CYAN + "Time spent in the garage: " + Program.ANSI_RESET + hours + " hours" +"\n"
                + Program.ANSI_CYAN + "Amount to pay: " + Program.ANSI_RESET + price + " euros" + "\n"
                + "══════════════════════════════════\n";
            return prettyPrint;
        }
    }
}
