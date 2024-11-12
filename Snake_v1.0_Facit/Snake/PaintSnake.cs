using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Snake
{
    internal class PaintSnake : IpaintSnake
    {
        public void PaintSnake1(int applesEaten, int[] xPositionIn, int[] yPositionIn, out int[] xPositionOut, out int[] yPositionOut)
        {
            
            
            // Rita ut snake huvud
            Console.SetCursorPosition(xPositionIn[0], yPositionIn[0]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("●");

            // Gör snake längre
            // Rita ut snake kropp
            for (int i = 1; i < applesEaten + 1; i++)
            {
                Console.SetCursorPosition(xPositionIn[i], yPositionIn[i]);
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("▪");
            }

            // Radera svansen av snake
            Console.SetCursorPosition(xPositionIn[applesEaten + 1], yPositionIn[applesEaten + 1]);
            Console.WriteLine(" ");

            // Notera varje del av snake
            for (int i = applesEaten + 1; i > 0; i--)
            {
                xPositionIn[i] = xPositionIn[i - 1];
                yPositionIn[i] = yPositionIn[i - 1];
            }

            // Returnera snake nya position
            xPositionOut = xPositionIn;
            yPositionOut = yPositionIn;
        }
    }
}
