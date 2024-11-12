using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Field
{
    internal class SnakeField
    {
        public static bool DidSnakeHitWall(int xPosition, int yPosition)
        {
            if (xPosition == 1 || xPosition == 70 || yPosition == 1 || yPosition == 40)
            {
                return true;
            }
            return false;
        }
        public static bool DetermineIfAppleIsEaten(int xPosition, int yPosition, int xPositionApple, int yPositionApple)
        {
            // Om snake huvud är på samma position som ett äpple... ät det!
            if (xPosition == xPositionApple && yPosition == yPositionApple) return true; return false;
        }
        public static  void BuildWall()
        {
            for (int i = 1; i <= 40; i++)
            {
                // Bygg lodrätta väggar
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, i);
                Console.Write("█");
                Console.SetCursorPosition(70, i);
                Console.Write("█");
            }
            // Bygg vågrätta väggar
            for (int i = 1; i <= 70; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(i, 1);
                Console.Write("█");
                Console.SetCursorPosition(i, 40);
                Console.Write("█");
            }
        }
    }
}
