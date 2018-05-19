using System;

namespace DSDV
{
    public class RoutingTableLine
    {
        string _destination;
        string _nextHop;
        int _metric;
        int _sequenceNumber;
        

        public int SequenceNumber
        {
            get
            {
                return _sequenceNumber;
            }

            set
            { 
                _sequenceNumber = value;
            }
        }

        public string Destination
        {
            get
            {
                return _destination;
            }
        }

        public string NextHop
        {
            get
            {
                return _nextHop;
            }

            set
            {
                _nextHop = value;
            }
        }

        public int Metric
        {
            get
            {
                return _metric;
            }

            set
            {
                _metric = value;
            }
        }

        public RoutingTableLine(string destination, string nextHop, int metric, int sequenceNumber = 0)
        {
            _destination = destination;
            _nextHop = nextHop;
            _metric = metric;
            _sequenceNumber = sequenceNumber;
        }

        public void Update(string nextHop, int metric, int sequenceNumber)
        {
            _nextHop = nextHop;
            _metric = metric;
            _sequenceNumber = sequenceNumber;
        }
   

        public override string ToString()
        {
            /*TODO install time*/
            return String.Format("{0,-6}{1,-6}{2,-6}{3,0}{4,0}", _destination, _nextHop, _metric == int.MaxValue ? "INF" : _metric.ToString(), _destination + "-", String.Format("{0,0:D3}", _sequenceNumber));
        }
    }
}
