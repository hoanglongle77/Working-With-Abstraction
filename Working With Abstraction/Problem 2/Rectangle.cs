using System;
using System.Collections.Generic;
using System.Text;

namespace Working_With_Abstraction.Problem_2
{
    internal class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;

        internal Point TopLeft { get => topLeft; set => topLeft=value; }
        internal Point BottomRight { get => bottomRight; set => bottomRight=value; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft=topLeft;
            BottomRight=bottomRight;
        }

        public bool Contains(Point point)
        {
            bool isInHorizontal = this.TopLeft.X <= point.X && this.BottomRight.X >= point.X;
            bool isInVertical = this.TopLeft.Y <= point.Y && this.BottomRight.Y >= point.Y;
            bool isInRectangle = isInHorizontal && isInVertical;
            return isInRectangle;
        }
    }
}
