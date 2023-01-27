using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineTicketSystem
{
    class Seats
    {
        protected int Seat;

        public int NumberOfSeats()
        {
            Console.WriteLine("Purchase Seats");
            Console.WriteLine("Please enter the number of seats you wish to purchase");
            Seat = Convert.ToInt16(Console.ReadLine());
            return Seat;
        }

        public void ConfirmSelection()
        {
            string choice;

            int seatPrice = 18;
            int totalPrice = Seat * seatPrice;
            Console.WriteLine("The total price for your selection is £" + totalPrice);
            Console.WriteLine("1. Confirm and proced to payment");
            Console.WriteLine("2. Cancel seletion");
            choice= Console.ReadLine();

            while (choice != null && choice !="1" && choice !="2")
            {
                Console.WriteLine("Please input a valid option");
                choice = Console.ReadLine();
            }

            switch(choice) 
            {
                case "1":
                    Console.WriteLine("You have successfully purchased tickets. Enjoy! ");
                    break;
                case "2":
                    Console.WriteLine("Seat selection was canceled");
                    break;
            }
        }
    }
}
