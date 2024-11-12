using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Apple
{
    internal class Apple1
    {
        private readonly IApplePosition _applePosition;
        private readonly IPaintApple _paintApple;
        public Apple1(IApplePosition applePosition,IPaintApple paintApple)
        {
            _applePosition = applePosition;
            _paintApple = paintApple;
        }
        public void SetApplePositionOnScreen(Random random, out int xPositionApple, out int yPositionApple)
        {
            _applePosition.SetApplePositionOnScreen(random, out xPositionApple, out yPositionApple);
        }
        public  void PaintApple1(int xPositionApple, int yPositionApple)
        {
            _paintApple.PaintApple1(xPositionApple, yPositionApple);
        }
    }
}
