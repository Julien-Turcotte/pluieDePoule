using System;
using System.Collections.Generic;
using System.Text;

namespace PluieDePoules
{
    public class Poule
    {
        public int x;
        public int y;

        public Poule(int x, int y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public void Tomber()
        {
            this.y = y + 1;
        }
    }
}
