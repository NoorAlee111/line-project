using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lineprojectfinal.LineBL;
using lineprojectfinal.MyPointBL;
using lineprojectfinal.LineUI;

namespace lineprojectfinal.LineBL
{
    class MyLine
    {
        public MyPoint begin;
        public MyPoint end;
        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;

        }
        public MyLine()
        {

        }
        public void setbegin(MyPoint begin)
        {
            this.begin = begin;
        }
        public MyPoint getbegin()
        {
            return begin;
        }


        public void setend(MyPoint end)
        {
            this.end = end;
        }
        public MyPoint getend()
        {
            return end;
        }
        public double getgradient()
        {
            double gradient = end.y - begin.y / end.x - begin.x;
            return gradient;
        }
        public double getlength()
        {
            double length = Math.Sqrt(Math.Pow((end.x - begin.x), 2) + Math.Pow((end.y - begin.y), 2));
            return length;
        }
    }
}
