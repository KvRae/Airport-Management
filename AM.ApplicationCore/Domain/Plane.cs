using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType { Boeing,Airbus}
    public class Plane
    {
       public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "PlaneType:  "+PlaneType+"ManufactureDate: "+ ManufactureDate;
        }

       
    }
    
}
