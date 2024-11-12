using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Apple
{
    internal interface IApplePosition
    {
        public void SetApplePositionOnScreen(Random random, out int xPositionApple, out int yPositionApple);
    }
}
