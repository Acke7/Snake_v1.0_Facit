using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Snake
{
    internal class Snake1
    {
        private readonly IpaintSnake _paintSnake;

        public Snake1( IpaintSnake paintSnake)
        {
            
            _paintSnake = paintSnake;
        }

     

        public void ReSetposition(int[] xPosition, int[] yPosition)
        {
             xPosition = new int[50];
            xPosition[0] = 35;
            yPosition = new int[50];
            yPosition[0] = 20;
        }

        public void PaintSnake(int applesEaten, int[] xPositionIn, int[] yPositionIn, out int[] xPositionOut, out int[] yPositionOut)
        {
            _paintSnake.PaintSnake1(applesEaten, xPositionIn, yPositionIn, out xPositionOut, out yPositionOut);
        }
    }
}
