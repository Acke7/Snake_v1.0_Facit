using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Apple
{
    internal class PaintApple: IPaintApple
    {
        public  void PaintApple1(int xPositionApple, int yPositionApple)
        {
            Console.SetCursorPosition(xPositionApple, yPositionApple);
            Console.ForegroundColor = ConsoleColor.Red;
            string appleIcon = "🍎";
            Console.WriteLine(appleIcon);
        }
    }
}
