using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lineprojectfinal.LineBL;
using lineprojectfinal.MyPointBL;
using lineprojectfinal.LineUI;

namespace lineprojectfinal
{
    class lineUI
    {
        static public MyLine line = new MyLine();
        public static void updatebeginpoint()
        {
            int x1;
            int y1;
            Console.Write("Enter the new x coordinate of begin point:");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the new y coordinate of begin point:");
            y1 = int.Parse(Console.ReadLine());
            MyPoint updatebegin = new MyPoint();
            updatebegin.setXY(x1, y1);
            line.setbegin(updatebegin);
        }
        public static void updateendpoint()
        {
            int x2;
            int y2;
            Console.Write("Enter the new x coordinate of end point:");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the new y coordinate of end point:");
            y2 = int.Parse(Console.ReadLine());
            MyPoint updateend = new MyPoint();
            updateend.setXY(x2, y2);
            line.setend(updateend);
        }
        public static void ShowEndPoint()
        {
            MyPoint end = new MyPoint();
            end = line.getend();
            Console.WriteLine("End Point:(" + end.x + "," + end.y + ")");
        }
        public static void ShowBeginPoint()
        {
            MyPoint begin = new MyPoint();
            begin = line.getbegin();
            Console.WriteLine("Begin Point:(" + begin.x + "," + begin.y + ")");
        }
        public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static int Menu()
        {
            int op = 0;
            Console.WriteLine("1:Make a Line");
            Console.WriteLine("2:Update the begin point");
            Console.WriteLine("3:Update the end point");
            Console.WriteLine("4:Show the begin Point");
            Console.WriteLine("5:Show the end point");
            Console.WriteLine("6:Get the Length of the line");
            Console.WriteLine("7:Get the Gradient of the Line");
            Console.WriteLine("8:Find the distance of begin point from zero coordinates");
            Console.WriteLine("9:Find the distance of end point from zero coordinates");
            Console.WriteLine("10:Exit");
            Console.WriteLine("Enter your option...");
            op = int.Parse(Console.ReadLine());
            return op;

        }
        public static void MakeaLine()
        {
            int x1;
            int y1;
            int x2;
            int y2;
            Console.Write("Enter x coordinate of begin point:");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate of begin point:");
            y1 = int.Parse(Console.ReadLine());
            MyPoint begin = new MyPoint(x1, y1);
            Console.Write("Enter x coordinate of begin point:");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate of begin point:");
            y2 = int.Parse(Console.ReadLine());
            MyPoint end = new MyPoint();
            end.setX(x2);
            end.setY(y2);
            line.setbegin(begin);
            line.setend(end);
        }
        public static void DisplayLength(double length)
        {
            Console.WriteLine("Length of the line:" + length);
        }
        public static void DisplayGradient(double gradient)
        {
            Console.WriteLine("Gradient of the line:" + gradient);
        }
        public static void DisplayDistanceofbeginpoint(double distance)
        {
            Console.WriteLine("Distance of begin point from zero coordinates:" + distance);
        }
        public static void DisplayDistanceofendpoint(double distance)
        {
            Console.WriteLine("Distance of end point from zero coordinates:" + distance);
        }
    }
}
