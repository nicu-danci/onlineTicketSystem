using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace onlineTicketSystem
{
    class Customer
    {
        //protected string firstName;
        //protected string lastName;
        //protected string address;
        //protected string emailAddress;

        //public void CustomerInfo()
        //{
        //    firstName = "";
        //    lastName = "";
        //    address = "";
        //    emailAddress = "";
        //}

        public void GetLogin()
        {
            string username;
            string password;

            Console.WriteLine("Welcome to the Bucks OTS");
            Console.WriteLine("Please login");
            Console.WriteLine("Enter username");
            username= Console.ReadLine();
            

            while (username.Length >10 || username.Length<3) 
            {
                Console.WriteLine("Username must be between 3 and 10 characters");
                Console.WriteLine("Enter username");
                username = Console.ReadLine();
            }

            Console.WriteLine("Enter password");
            password= Console.ReadLine();

            while (password.Length>10 || password.Length<3)
            {
                Console.WriteLine("Password must be between 3 and 10 characters");
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
            }
        }
    } 
}
