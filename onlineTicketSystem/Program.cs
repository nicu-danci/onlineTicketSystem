using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace onlineTicketSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var menu = new MainMenu();

            customer.GetLogin();
            menu.HomeMenu();
        }
    }
}
