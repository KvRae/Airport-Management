using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public String PassportNumber { get; set; }
        public String EmailAddress { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String TelNumber { get; set; }

        public ICollection<Flight> Flights { get; set; }

        

        public bool CheckProfile(String FirstName, String lastName,String Email=null)
        {
            if (Email == null)
              {
                return (this.FirstName == FirstName && LastName == lastName);

              }
            else
            {
                return (this.FirstName == FirstName && LastName == lastName && EmailAddress == Email);

            }

           
        }

        public virtual void PassengerType ()
        {
            Console.WriteLine("I'am a passenger");

        }


    }
}
