using Snake_v1._0_Facit.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_v1._0_Facit
{
    internal class App
    {
        public void Run()
        {
            GoGame goGame = new GoGame();
            goGame.Start();

        }
    }
}
