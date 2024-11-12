using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Snake
{
    internal interface IpaintSnake
    {
         void PaintSnake1(int applesEaten, int[] xPositionIn, int[] yPositionIn, out int[] xPositionOut, out int[] yPositionOut);
    }
}
