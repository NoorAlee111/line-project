using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lineprojectfinal.LineBL;
using lineprojectfinal.MyPointBL;
using lineprojectfinal.LineUI;
using lineprojectfinal;

namespace lineprojectfinal
{
    class Program
    {
        static void Main(string[] args)
        {


            int op = 0;
            while (true)
            {
                op = lineUI.Menu();
                if (op == 1)
                {
                    lineUI.MakeaLine();
                }
                else if (op == 2)
                {
                    lineUI.updatebeginpoint();
                }
                else if (op == 3)
                {
                    lineUI.updateendpoint();
                }
                else if (op == 4)
                {
                    lineUI.ShowBeginPoint();
                }
                else if (op == 5)
                {
                    lineUI. ShowEndPoint();
                }
                else if (op == 6)
                {
                    double length = lineUI. line.getlength();
                    lineUI. DisplayLength(length);
                }
                else if (op == 7)
                {
                    double gradient = lineUI.line.getgradient();
                    lineUI. DisplayGradient(gradient);


                }
                else if (op == 8)
                {
                    double distance = lineUI.line.begin.distancefromzero();
                    lineUI.DisplayDistanceofbeginpoint(distance);
                }
                else if (op == 9)
                {
                    double distance = lineUI.line.end.distancefromzero();
                    lineUI.DisplayDistanceofendpoint(distance);
                }
                else if (op == 10)
                {
                    break;
                }
                lineUI.clearScreen();
            }
        }
    }

}
