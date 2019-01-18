using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blogClassLibrary;

namespace blogConsoleApp
{
    class Program
    {
         private static void DisplayMenu()
        {
            Console.WriteLine("Blog in C#{0}", Environment.NewLine);
            Console.WriteLine("--------------------------------------------");
            // display nr of posts here, in the phranteses
            Console.WriteLine("################## Posts (0) ############### {0}", Environment.NewLine);
            Console.WriteLine("There are no posts to show at this moment");
            Console.WriteLine("--------------------------------------------{0}", Environment.NewLine);
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Add a new post");
            Console.WriteLine("2 - Create a new account");
            Console.WriteLine("X - Exit");
        }

        static void Main(string[] args)
        {
            DisplayMenu();
            Console.ReadLine();
        }
    }
}
