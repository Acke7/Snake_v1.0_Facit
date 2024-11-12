using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Menu
{
    internal class MAinMenu
    {
        public  void ShowMenu(out string userAction)
        {
            Console.Clear();
            Console.WriteLine("1: How to play");
            Console.WriteLine("2: Play");
            Console.WriteLine("3: Exit");

            userAction = Console.ReadLine().ToLower();
        }
    }
}
