using System;
using System.Threading;

namespace Snake_v1._0_Facit.Menu
{
    public class WelcomePage
    {
        public void Welcome()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Set the console window size and colors
            Console.SetWindowSize(120, 50);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            // Display ASCII art for the title centered
            DisplayTitle();

            // Draw a "snake" moving across the screen with a snake-like texture
            AnimateSnake();

            // Display "Press any key to continue" with a blinking effect, centered
            BlinkingMessage("Press any key to continue...");

            // Wait for the user to press a key
            Console.ReadKey();
            Console.ResetColor();
        }

        private void DisplayTitle()
        {
            string[] titleArt = new[]
            {
                "  _____             _       _____                ",
                " / ____|           | |     |  __ \\               ",
                "| (___   __ _ _   _| | __ _| |__) |   _ _ __ ___ ",
                " \\___ \\ / _` | | | | |/ _` |  ___/ | | | '__/ _ \\",
                " ____) | (_| | |_| | | (_| | |   | |_| | | |  __/",
                "|_____/ \\__,_|\\__,_|_|\\__,_|_|    \\__,_|_|  \\___|",
            };

            int startY = 5;
            int startX = (Console.WindowWidth - titleArt[0].Length) / 2;

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (string line in titleArt)
            {
                Console.SetCursorPosition(startX, startY++);
                Console.WriteLine(line);
            }
        }

        private void AnimateSnake()
        {
            string snakeBody = "\U0001F40D";
            int startX = 5;
            int y = 15;

            for (int i = 0; i < 40; i++) // Adjust to make the snake move across the screen
            {
                Console.SetCursorPosition(startX + i, y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(snakeBody);

                Thread.Sleep(150); // Pause to create movement effect

                // Clear the snake's previous position
                Console.SetCursorPosition(startX + i, y);
                Console.Write(new string(' ', snakeBody.Length));
            }
        }

        private void BlinkingMessage(string message)
        {
            int x = (Console.WindowWidth - message.Length) / 2;
            int y = 20;
            for (int i = 0; i < 10; i++) // Blinks for 10 cycles
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = i % 2 == 0 ? ConsoleColor.Cyan : ConsoleColor.DarkGray;
                Console.Write(message);
                Thread.Sleep(500); // Adjust delay for blinking speed
            }
        }
    }
}
