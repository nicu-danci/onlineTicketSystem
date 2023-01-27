using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineTicketSystem
{
    class MainMenu
    {
        public void HomeMenu()
        {
            string showName = "";

            var show = new Show();
            var seats = new Seats();

            string choice;

            Console.WriteLine("Login succesfully");
            Console.WriteLine("1. View upcoming events");
            Console.WriteLine("2. Logout");
            Console.WriteLine("Please input an option");
            choice = Console.ReadLine();

            while (choice !="1" && choice !="2" && choice != null)
            {
                Console.WriteLine("Please input a valid option");
                choice = Console.ReadLine();
            }

        switch (choice)
            {
            case "1":
                show.SelectShow(showName);
                seats.NumberOfSeats();
                seats.ConfirmSelection();
                break;

            case "2":
                Environment.Exit(0);
                break;
             };
        }
    }
}
