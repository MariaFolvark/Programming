using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal static class CollisionManager
    {
        public static bool IsCollision(Rectangles rectangle1, Rectangles rectangle2)
        {
            double deltaX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double deltaY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            double sumHalfWidths = (rectangle1.Width / 2) + (rectangle2.Width / 2);
            double sumHalfLengths = (rectangle1.Length / 2) + (rectangle2.Length / 2);

            bool isCollidingX = deltaX < sumHalfWidths;
            bool isCollidingY = deltaY < sumHalfLengths;

            return isCollidingX && isCollidingY;

        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double deltaX = Math.Abs(ring1.Center.X - ring2.Center.X);
            double deltaY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double distanceCenters = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            if (distanceCenters < ring1.OuterRadius + ring2.OuterRadius)
            {
                return true;
            }
            /*
            if (distanceCenters < (ring1.OuterRadius + ring2.OuterRadius))
            {
                if (ring1.OuterRadius < ring2.InnerRadius || ring2.OuterRadius < ring1.InnerRadius)
                return true;
            }*/

            return false;
        }
    }
}
