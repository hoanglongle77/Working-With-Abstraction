using System;
using System.Collections.Generic;
using System.Text;

namespace Working_With_Abstraction.Problem_2
{
    internal class Point
    {
        private int x;
        private int y;

        public int X { get => x; set => x=value; }
        public int Y { get => y; set => y=value; }

        public Point(int x, int y)
        {
            X=x;
            Y=y;
        }

    }
}
