using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lineprojectfinal.LineBL;
using lineprojectfinal.MyPointBL;
using lineprojectfinal.LineUI;

namespace lineprojectfinal.MyPointBL
{
    class MyPoint
    {
        public int x;
        public int y;
        public MyPoint()
        {
            x = 0;
            y = 0;

        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public int getX()
        {
            return x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int getY()
        {
            return y;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double DistanceWithCords(int x, int y)
        {
            double distance = Math.Sqrt(Math.Pow((x - this.x), 2) + Math.Pow((y - this.y), 2));
            return distance;
        }
        public double distanceWithObject(MyPoint another)
        {
            double distance = Math.Sqrt(Math.Pow((another.x - x), 2) + Math.Pow((another.y - this.y), 2));
            return distance;
        }
        public double distancefromzero()
        {
            double distance = Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2));
            return distance;
        }
    }
}
