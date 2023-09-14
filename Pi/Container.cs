using System.Collections.Generic;
using System.Threading;

namespace Pi
{
    public class Container
    {
        public double Pi
        {
            get;
            set;
        }

        public CountdownEvent Event
        {
            get;
            set;
        }

        public List<Point> Points { 
            get; 
            set; 
        }

        public Container(CountdownEvent ev, List<Point> points)
        {
            this.Event = ev;
            this.Points = points;
        }
    }
}