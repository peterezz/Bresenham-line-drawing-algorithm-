using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bresenham
{
    class Bresenham
    {
        public List<int> lineBres(int x0, int y0, int xEnd, int yEnd)
        {
            int dx = Math.Abs(xEnd - x0);
            int dy = Math.Abs(yEnd - y0);
            int x, y, p =( 2 * dy) - dx;
            int twody = 2 * dy;
            int twodymindx = 2 * (dy - dx);
            List<int> pionts = new List<int>();
            
            if (x0 > xEnd)
            {
                x = xEnd;
                y = yEnd;
                xEnd = x0;
            }
            else
            {

                x = x0; y = y0;
            }
            //arr
            pionts.Add(x);
            pionts.Add(y);
            
            while (x<xEnd)

            {
               
                x++;
                if (p<0)
                {
                    p = p + twody;
                }
                else
                {
                    y++;
                    p = p + twodymindx;
                }
                pionts.Add(x);
                pionts.Add(y);

            }


            return pionts;
        }
    }
}
