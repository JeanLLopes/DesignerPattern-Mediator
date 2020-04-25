using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MarkerPositions
{
    public class MarkerMediator
    {
        private List<Marker> markers = new List<Marker>();

        public Marker CreateMaker()
        {
            var marker = new Marker();
            marker.SetMediator(this);
            this.markers.Add(marker);
            return marker;
        }

        public void Send(Point location, Marker marker)
        {
            this.markers.Where(x => x != marker).ToList().ForEach(x => x.ReceiveLocation(location));
        }
    }
}
