using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight:IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            // List<DateTime> dates = new List<DateTime>();
            /*   for (int i = 0; i < Flights.Count; i++)
               {
                   if (Flights[i].Destination == destination){
                       dates.Add(Flights[i].FlightDate);
                   }

               }*/
            /*foreach(Flight flight in Flights)
               {
                   if (flight.Destination == destination)
                   {
                       dates.Add(flight.FlightDate);
                   }
               }*/
            IEnumerable<DateTime> req = from f in Flights 
                                      where f.Destination == destination 
                                      select f.FlightDate;
            return req.ToList();


        }


        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.EstimatedDuration == Int32.Parse(filterValue))
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "Departure":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.Departure == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

            }
        }

        public void ShowFlightDetails(Plane plane)
        {
            var req = from f in Flights
                                      where f.Plane == plane
                                      select new { f.FlightDate, f.Destination };
        foreach(var f in req)
            {
                Console.WriteLine(f);
            }
        }
    }
}
