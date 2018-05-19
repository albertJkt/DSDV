using System;
using System.Collections.Generic;
using System.IO;

namespace DSDV
{
    public class RoutingTable
    {
        List<RoutingTableLine> _routingTableLines;
        Dictionary<RoutingTableLine, int> _ownRoutingTableLines;

        public List<RoutingTableLine> RoutingTableLines
        {
            get
            {
                return _routingTableLines;
            }

            set
            {
                _routingTableLines = value;
            }
        }
     
        public RoutingTable(string router)
        {
            _routingTableLines = new List<RoutingTableLine>();
            _ownRoutingTableLines = new Dictionary<RoutingTableLine, int>();
            AddLine(router, router, 0, 0);
        }


        public RoutingTableLine OwnLine()
        {
            return _routingTableLines.Find(x => x.Metric == 0);
        }

        public void AddLine(string destination, string nextHop, int metric, int sequenceNumber, int time = 0)
        {
            var newLine = new RoutingTableLine(destination, nextHop, metric, sequenceNumber);
            _routingTableLines.Add(newLine);
            _ownRoutingTableLines.Add(newLine, time);

        }

        public void DeleteLines()
        {
            var toDelete = _routingTableLines.FindAll(x => x.SequenceNumber.IsOdd());
            foreach(var line in toDelete)
            {
                _ownRoutingTableLines.Remove(line);
            }
            _routingTableLines.RemoveAll(x => x.SequenceNumber.IsOdd());
        }

        public void PrintTable()
        {
            Console.WriteLine("-" + OwnLine().Destination + "-----------------------------");
            Console.WriteLine(String.Format("{0,-6}{1,-6}{2,-6}{3,-9}{4,0}", "Dest", "Next", "Metr", "Numb", "Inst"));
            foreach (var line in _routingTableLines)
            {
                Console.WriteLine(line.ToString() + String.Format("{0, 8}", _ownRoutingTableLines[line]));
            }
            Console.WriteLine("--------------------------------");
        }

        public void UpdateTable(RoutingTable receivedTable, int metric, int time, int updateSeconds)
        {
            InstallTime(receivedTable, time);
            BrokenLink(receivedTable);
            if (NewNeighbor(receivedTable, metric, time) || NewRouter(receivedTable, metric, time) || UpdateLines(receivedTable, metric))
            {
                OwnLine().SequenceNumber += 2;
            }
            _routingTableLines.Find(x => x.Destination == receivedTable.OwnLine().Destination).SequenceNumber = receivedTable.OwnLine().SequenceNumber;
        }


        public bool UpdateLines(RoutingTable receivedTable, int metric)
        {
            var updated = false;
            var receivedTableOwnLine = receivedTable.OwnLine();
            var neighborLine = _routingTableLines.Find(x => x.Destination == receivedTableOwnLine.Destination);
            var toChange = _routingTableLines.FindAll(x => x.Destination == receivedTableOwnLine.Destination);
            if (receivedTableOwnLine.SequenceNumber > neighborLine.SequenceNumber)
            {
                foreach (var line in toChange)
                {
                    var infoLine = receivedTable.RoutingTableLines.Find(x => x.Destination == line.Destination);
                    if (infoLine.SequenceNumber > line.SequenceNumber && line.NextHop == receivedTable.OwnLine().Destination)
                    {
                        if (infoLine.Metric + metric < line.Metric)
                        {
                            updated = true;
                            line.Update(receivedTableOwnLine.Destination, metric + infoLine.Metric, infoLine.SequenceNumber);
                        }
                    }
                }
            }
            foreach (var line in _routingTableLines)
            {
                var infoLine = receivedTable.RoutingTableLines.Find(x => x.Destination == line.Destination);
                if (infoLine != null && infoLine.SequenceNumber > line.SequenceNumber && infoLine.Metric + metric == line.Metric)
                {
                    line.Update(line.NextHop, line.Metric, infoLine.SequenceNumber);
                }
            }
            return updated;
        }

        public void InstallTime(RoutingTable receivedTable, int time)
        {
            var lines = _routingTableLines.FindAll(x => x.NextHop == receivedTable.OwnLine().Destination);
            foreach (var line in lines)
            {
                _ownRoutingTableLines[line] = time;
            }
        }

        public void ChangeWeight(RoutingTable routingTable, int newWeight, string neighbor)
        {
            var neighborLine = routingTable.RoutingTableLines.Find(x => x.Destination == neighbor);
            int oldWeight = neighborLine.Metric;

            routingTable.OwnLine().SequenceNumber += 2;
            neighborLine.SequenceNumber += 2;

            var toChange = routingTable.RoutingTableLines.FindAll(x => x.NextHop == neighborLine.Destination);
            foreach (var line in toChange)
            {
                line.Metric += newWeight - oldWeight;
            } 
        }

        public bool NewNeighbor(RoutingTable receivedTable, int metric, int time)
        {
            var updated = false;   
            var infoLine = receivedTable.OwnLine();
            if(!_routingTableLines.Exists(x => x.Destination == infoLine.Destination))
            {
                AddLine(infoLine.Destination, infoLine.Destination, metric, infoLine.SequenceNumber, time);
                updated = true;
            }
            return updated;
        }

        public bool NewRouter(RoutingTable receivedTable, int metric, int time)
        {
            bool updated = false;
            var infoLine = receivedTable.OwnLine();
            var neighborLine = _routingTableLines.Find(x => x.Destination == receivedTable.OwnLine().Destination);
            if (infoLine.SequenceNumber == neighborLine.SequenceNumber)
            {
                foreach (var line in receivedTable._routingTableLines)
                {
                    if (!_routingTableLines.Exists(x => x.Destination == line.Destination) && !line.SequenceNumber.IsOdd())
                    {
                        AddLine(line.Destination, infoLine.Destination, metric + line.Metric, line.SequenceNumber, time);
                        updated = true;
                    }
                }
             }
               if (infoLine.SequenceNumber > neighborLine.SequenceNumber)
               {
                foreach (var line in receivedTable._routingTableLines)
                {
                    if (!_routingTableLines.Exists(x => x.Destination == line.Destination) && !line.SequenceNumber.IsOdd())
                    {
                        AddLine(line.Destination, infoLine.Destination, metric + line.Metric, line.SequenceNumber, time);
                        updated = true;
                    }
                    else
                    {
                        var toCheck = _routingTableLines.Find(x => x.Destination == line.Destination);
                        {
                            if (toCheck.Metric > line.Metric + metric)
                            {
                                toCheck.Update(infoLine.Destination, line.Metric + metric, line.SequenceNumber);
                                updated = true;

                            }
                        }
                    }
                }
            }
            
            
            return updated;
        }

        public bool newLink(Router router)
        {
            var updated = false;
            RoutingTableLine neighLine;
            foreach(var neigh in router.Neighbor)
            {
                neighLine = router.RoutingTable.RoutingTableLines.Find(x => x.Destination == neigh.Key.Name);
                if (neighLine != null && neighLine.Metric > neigh.Value && !neighLine.SequenceNumber.IsOdd())
                {
                    neighLine.Update(neighLine.Destination, neigh.Value, neighLine.SequenceNumber);
                    updated = true;
                }
            }
            return updated;
        }

        public void BrokenLink(Router router, int time, int updateSeconds)
        {
            var brokenLinks = _routingTableLines.FindAll(x => x.Destination != OwnLine().Destination && (_ownRoutingTableLines[x] < time -  updateSeconds * 3) && !x.SequenceNumber.IsOdd());
            foreach(var line in brokenLinks)
            {
                router.RoutingTable.BrokenLink(line.Destination);
            }

        }

        public void BrokenLink(string name)
        {
            var line = _routingTableLines.Find(x => x.Destination == name);
            line.Metric = int.MaxValue;
            var linesToChange = _routingTableLines.FindAll(x => x.NextHop == name);
            if (linesToChange != null)
            {
                foreach (var changeLine in linesToChange)
                {
                    changeLine.Metric = int.MaxValue;
                    changeLine.SequenceNumber++;
                }
            }  
        }

        public void BrokenLink(RoutingTable receivedTable)
        {
            var infoLine = receivedTable.OwnLine();
            foreach (var line in receivedTable._routingTableLines)
            {
                if (line.SequenceNumber.IsOdd())
                {
                    var toChange = _routingTableLines.Find(x => x.Destination == line.Destination && x.NextHop == infoLine.Destination);
                    if (toChange != null)
                    {
                        toChange.Update(line.NextHop, line.Metric, line.SequenceNumber);
                    }
                }
            }
        }
    }
}