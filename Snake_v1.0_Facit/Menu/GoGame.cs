using Snake_v1._0_Facit.Apple;
using Snake_v1._0_Facit.Field;
using Snake_v1._0_Facit.Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Menu
{
    public class GoGame
    {
         
        public void Start()
        {
          
            var showMenu = new MAinMenu();
            var instruction = new Instruction();
            var welcomePage = new WelcomePage();
            IpaintSnake paintSnake = new PaintSnake();
            var snake = new Snake1(paintSnake);
            IApplePosition applePosition = new ApplePosition();
            IPaintApple paintApple = new PaintApple();
            var apple = new Apple1(applePosition,paintApple);
            //SnakePosition snakePosition = new SnakePosition();
            int applesEaten = 0;
            int[] xPosition = new int[50];
            xPosition[0] = 35;
            int[] yPosition = new int[50];
            yPosition[0] = 20;
            int xPositionApple = 10;
            int yPositionApple = 10;
            Random random = new Random();

            // Ta bort cursor... endast estetiskt
            Console.CursorVisible = false;
            string userAction = " ";
            decimal gameSpeed = 150m;
            bool isGameOn = true;
            bool isWallHit = false;
            bool isAppleEaten = false;
            bool isStayInMenu = true;
            
            do
            {
                welcomePage.Welcome();
                // Gör en välkomstskärm (meny)
                // Låt spelaren läser instruktionerna om han vill
                showMenu.ShowMenu(out  userAction);

                // Om spelare väljer att spela igen...
                // Reset snake
                snake.ReSetposition(xPosition,yPosition);
                // Reset även denna
                isGameOn = true;

                switch (userAction)
                {
                    case "1":
                        instruction.ShowInstructions(userAction);
                        break;
                    case "2":
                        Console.Clear();
                        #region Game Setup
                        // Visa new snake array på skrämen
                        snake.PaintSnake(applesEaten, xPosition, yPosition, out xPosition, out yPosition);

                        // Placera FÖRSTA äpplet random ställe på skärmen
                        // out - ändrar de globala variabler också (inte bara de lokala inom metoden)
                        apple.SetApplePositionOnScreen(random, out xPositionApple, out yPositionApple);
                        apple.PaintApple1(xPositionApple, yPositionApple);

                        // Rita border
                        SnakeField.BuildWall();

                        // Läs instruktion från användaren
                        ConsoleKey command = Console.ReadKey().Key;
                        #endregion

                        #region Game Loop
                        // Flytta på snake
                        do
                        {
                            #region Change Directions
                            switch (command)
                            {
                                case ConsoleKey.LeftArrow:
                                    Console.SetCursorPosition(xPosition[0], yPosition[0]);
                                    Console.Write(" ");
                                    xPosition[0]--;
                                    break;
                                case ConsoleKey.UpArrow:
                                    Console.SetCursorPosition(xPosition[0], yPosition[0]);
                                    Console.Write(" ");
                                    yPosition[0]--;
                                    break;
                                case ConsoleKey.RightArrow:
                                    Console.SetCursorPosition(xPosition[0], yPosition[0]);
                                    Console.Write(" ");
                                    xPosition[0]++;
                                    break;
                                case ConsoleKey.DownArrow:
                                    Console.SetCursorPosition(xPosition[0], yPosition[0]);
                                    Console.Write(" ");
                                    yPosition[0]++;
                                    break;
                            }
                            #endregion

                            #region Playing Game
                            // Visa new snake array på skrämen
                            snake.PaintSnake(applesEaten, xPosition, yPosition, out xPosition, out yPosition);

                            // Känner av när snake (head) träffa väggen
                            isWallHit = SnakeField.DidSnakeHitWall(xPosition[0], yPosition[0]);

                            if (isWallHit)
                            {
                                isGameOn = false;
                                Console.SetCursorPosition(32, 20);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Game Over");

                                // Visa final score
                                Console.SetCursorPosition(30, 22);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(@"Din score är ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(applesEaten);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(20, 24);
                                Console.WriteLine("Tryck på valfri knapp för att fortsätta");
                                applesEaten = 0;

                                // Raderar äpplet vid game over
                                Console.SetCursorPosition(xPositionApple, yPositionApple);
                                Console.Write(" ");

                                Console.ReadLine();
                                Console.Clear();

                                // Låt spelaren välja att spela igen
                                // ShowMenu(out userAction);

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.SetCursorPosition(1, 42);
                            }

                            // Känner av om äpplet har ätits upp av snake
                            isAppleEaten = SnakeField.DetermineIfAppleIsEaten(xPosition[0], yPosition[0], xPositionApple, yPositionApple);

                            if (isAppleEaten)
                            {
                                // Placera äpple random ställe på skärmen
                                // out - ändrar de globala variabler också (inte bara de lokala inom metoden)
                                apple.SetApplePositionOnScreen(random, out xPositionApple, out yPositionApple);
                                apple.PaintApple1(xPositionApple, yPositionApple);

                                // Lägg antalet uppätna äpplen i en variabel (score)
                                applesEaten++;
                                // Gör snake snabbare
                                gameSpeed *= .925m;
                            }

                            if (Console.KeyAvailable) command = Console.ReadKey().Key;

                            // Slow game down
                            System.Threading.Thread.Sleep(Convert.ToInt32(gameSpeed));

                            #endregion
                        }
                        while (isGameOn);
                        #endregion
                        break;
                    case "3":
                        isStayInMenu = false;
                        break;
                    default:
                        Console.WriteLine("Inte ett giltigt val. Försök igen");
                        Console.ReadLine();
                        Console.Clear();
                        // ShowMenu(out userAction);
                        break;
                }
            } while (isStayInMenu);
        }


    }
}
