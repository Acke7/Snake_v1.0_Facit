using Snake_v1._0_Facit.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Menu
{
    internal class Instruction
    {
        public  void ShowInstructions(string userAction)
        {
            Console.Clear();
            SnakeField.BuildWall();
            Console.SetCursorPosition(12, 5);
            Console.WriteLine("Använd pilarna för att flytta ormen runt banan");
            Console.SetCursorPosition(16, 7);
            Console.WriteLine("Ormen dör om den träffar yttreväggen");
            Console.SetCursorPosition(20, 9);
            Console.WriteLine("Ät äpplen för att få poäng!");
            Console.SetCursorPosition(13, 11);
            Console.WriteLine("Varje äpple gör ormen längre och snabbare!");
            Console.SetCursorPosition(14, 13);
            Console.WriteLine("Tryck på valfri knapp för att fortsätta");
            Console.ReadLine();
            Console.Clear();
            //ShowMenu(out userAction);
        }
    }
}
