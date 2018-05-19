using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSDV
{
    public static class Program
    {

        public static int _refreshTime = 3;
        public static Router _messageAt;
        public static bool IsOdd(this int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public static void Info(this bool info, Label label)
        {
            if (info)
            {
                label.Text = "SUCCESS";
            }
            else
            {
                label.Text = "ERROR";
            }
        }

        public static void Main(string[] args)
        {
           
            var routerA = new Router("A");
            var routerB = new Router("B");
            var routerC = new Router("C");
            var routerD = new Router("D");
            var routerE = new Router("E");
            var routerF = new Router("F");

            var routerH = new Router("H");
            var routerP = new Router("P"); 

            Graph.AddRouter(routerA);
            Graph.AddRouter(routerB);
            Graph.AddRouter(routerC);
            Graph.AddRouter(routerD);
            Graph.AddRouter(routerF);
            Graph.AddRouter(routerH);
            Graph.AddRouter(routerP);

            var task = Task.Run(() => Graph.SendTables());

            /*    routerA.AddNeighbor(routerC, 2);
                routerA.AddNeighbor(routerB, 4);
                routerB.AddNeighbor(routerC, 8);*/
            /*        
                    routerA.AddNeighbor(routerB, 5);
                    routerA.AddNeighbor(routerD, 6);
                    routerB.AddNeighbor(routerC, 5); */

            /*   routerA.AddNeighbor(routerB, 4);
               routerA.AddNeighbor(routerC, 9);
               routerB.AddNeighbor(routerE, 9);
               routerB.AddNeighbor(routerD, 5);
               routerD.AddNeighbor(routerC, 6);
               routerF.AddNeighbor(routerC, 4);
               routerF.AddNeighbor(routerE, 3);
               routerE.AddNeighbor(routerD, 2);*/

            routerA.AddNeighbor(routerB, 6);
            routerA.AddNeighbor(routerC, 8);
            routerA.AddNeighbor(routerD, 5);
            routerD.AddNeighbor(routerC, 10);
            routerB.AddNeighbor(routerF, 11);
            routerF.AddNeighbor(routerC, 1);
            routerF.AddNeighbor(routerH, 100);
            routerH.AddNeighbor(routerP, 10);


            Application.Run(new Meniu());
            Console.ReadLine();
        }

    }
}
