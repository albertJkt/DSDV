
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DSDV
{
    public class Router
    {
        string _name;
        Dictionary<Router, int> _neighbors;
        RoutingTable _routingTable;


        public Router(string name)
        {
            _neighbors = new Dictionary<Router, int>();
            _name = name;
            _routingTable = new RoutingTable(this.Name);
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Dictionary<Router, int> Neighbor
        {
            get
            {
                return _neighbors;
            }
            set
            {
                _neighbors = value;
            }
        }

        public RoutingTable RoutingTable
        {
            get
            {
                return _routingTable;
            }

            set
            {
                _routingTable = value;
            }
        }

        public void AddNeighbor(Router router, int weight)
        {
            if (!_neighbors.ContainsKey(router))
            { 
                _neighbors.Add(router, weight);
                router._neighbors.Add(this, weight);
            }
        }

        public void DeleteNeighbor(Router router)
        {
            _neighbors.Remove(router);
            router._neighbors.Remove(this);
        } 

        public void ChangeWeight(Router neighbor, int weight)
        {
            _neighbors[neighbor] = weight;
            _routingTable.ChangeWeight(_routingTable, weight, neighbor.Name);
            neighbor.Neighbor[this] = weight;
        }

        public void SendTable(Router receiver, int time, int updateSeconds)
        {
            receiver.ReceiveTable(this.RoutingTable, this, time, updateSeconds);
        }

        public void ReceiveTable(RoutingTable table, Router sender, int time, int updateSeconds)
        {
            RoutingTable.UpdateTable(table, _neighbors[sender], time, updateSeconds);
        }

        public void Message(string to, Label label, TextBox textBox)
        {
            if (Name == to)
            {
                label.Text += " **Delivered**";
                Program._messageAt = null;
            }
            else
            {
                var nextLine = _routingTable.RoutingTableLines.Find(x => x.Destination == to);
                if (nextLine != null && Program._messageAt != null)
                {
                    try
                    {
                        Program._messageAt = Graph.Routers.Find(x => x.Name == nextLine.NextHop);
                        textBox.Text = Program._messageAt.Name;
                        label.Text += Program._messageAt.Name;
                    }
                    catch(Exception){}
                    
                }
                else
                {
                    label.Text += " **Error**";
                }
            }
        }
    }
}
