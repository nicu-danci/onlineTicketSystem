using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineTicketSystem
{
    class Show
    {
        protected string showName;

        public void showDetails()
            {
                showName = "";
            }

        public void SelectShow(string showName)
        {
            string choice;
            Console.WriteLine("1. Lewis Capaldi");
            Console.WriteLine("2. New Order");
            Console.WriteLine("3. The Johnny Cash Roadshow");
            Console.WriteLine("4. The Cher Show");
            Console.WriteLine("5. Black Flag");
            Console.WriteLine("6. Catapult Club Presents Brad Walton");
            Console.WriteLine("Please input an option");
            choice = Console.ReadLine();

            while (choice !=null && choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5" && choice != "6")
            {
                Console.WriteLine("Please input a valid option");
                choice = Console.ReadLine();
            }

            switch(choice) 
            {
                case "1":
                    showName = "Lewis Capaldi";
                    break;
                case "2":
                    showName = "New Order";
                    break;
                case "3":
                    showName = "The Johnny Cash Roadshow";
                    break;
                case "4":
                    showName = "The Cher Show";
                    break;
                case "5":
                    showName = "Black Flag";
                    break;
                case "6":
                    showName = "Catapult Club Presents Brad Walton";
                    break;
            }
            this.showName = showName;
        }
    }

}
