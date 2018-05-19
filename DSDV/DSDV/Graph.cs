using System;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DSDV
{
    public static class Graph
    {
        static List<Router> _routers = new List<Router>();
        public static bool print = true;

        public static List<Router> Routers
        {
            get
            {
                return _routers;
            }

            set
            {
                _routers = value;
            }
        }

        public static bool AddRouter(Router router)
        {
            if (!_routers.Exists(x => x.Name == router.Name))
            {
                _routers.Add(router);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RemoveRouter(string routerName)
        {
            var toRemove = _routers.Find(x => x.RoutingTable.OwnLine().Destination == routerName);
            if (toRemove != null)
            {
                foreach(var router in _routers)
                {
                    router.Neighbor.Remove(toRemove);
                }
                _routers.Remove(toRemove);
                return true;
            }
            return false;
        }

        public static bool RemoveLink(string routerA, string routerB)
        {
            var ok = false;
            var toRemoveA = _routers.Find(x => x.Name == routerA);
            var toRemoveB = _routers.Find(x => x.Name == routerB);

            if (toRemoveA != null && toRemoveB != null)
            {
                if(toRemoveA.Neighbor.ContainsKey(toRemoveB))
                {
                    toRemoveA.DeleteNeighbor(toRemoveB);
                    ok = true;
                }
            }
            return ok;
        }

        public static bool AddLink(string routerA, string routerB, int weight)
        {
            var ok = false;
            var toAddA = _routers.Find(x => x.Name == routerA);
            var toAddB = _routers.Find(x => x.Name == routerB);
            if (toAddA != null && toAddB != null && toAddA != toAddB)
            {
                if(!toAddA.Neighbor.ContainsKey(toAddB))
                {
                    toAddA.AddNeighbor(toAddB, weight);
                    ok = true;
                }
            }
            return ok;
        }

        public static bool ChangeWeight(string routerA, string routerB, int weight)
        {
            var ok = false;
            var toChangeA = _routers.Find(x => x.Name == routerA);
            var toChangeB = _routers.Find(x => x.Name == routerB);
            
            if(toChangeA != null && toChangeB != null && toChangeA.Neighbor.ContainsKey(toChangeB))
            {
                toChangeA.ChangeWeight(toChangeB, weight);
                ok = true;
            }
            return ok;
        }

        public async static void SendTables()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            while (true)
            {
                Console.Clear();
                foreach (var router in _routers)
                {
                    var updated = false;
                    router.RoutingTable.BrokenLink(router, stopWatch.Elapsed.Minutes * 60 + stopWatch.Elapsed.Seconds, Program._refreshTime);
                    if (router.RoutingTable.newLink(router))
                    {
                        updated = true;
                    }
                    if (updated)
                    {
                        router.RoutingTable.OwnLine().SequenceNumber += 2;
                    }
                    if (print)
                    {
                        router.RoutingTable.PrintTable();
                    }
                    foreach (var neigh in router.Neighbor)
                    {
                        router.SendTable(neigh.Key, stopWatch.Elapsed.Minutes * 60 + stopWatch.Elapsed.Seconds, Program._refreshTime * 1000);
                    }
                    router.RoutingTable.DeleteLines();
                }
                await Task.Delay(Program._refreshTime * 1000);
            }  
        }
    }
}


