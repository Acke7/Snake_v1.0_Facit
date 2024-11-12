using Snake_v1._0_Facit.Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit.Apple
{
    internal class ApplePosition : IApplePosition
    {
      
        public  void SetApplePositionOnScreen(Random random, out int xPositionApple, out int yPositionApple)
        {
            // +2 -2 används för att äpplet ska skapas INOM spelarenan!
            xPositionApple = random.Next(0 + 2, 70 - 2);
            yPositionApple = random.Next(0 + 2, 40 - 2);
        }
    }
}
