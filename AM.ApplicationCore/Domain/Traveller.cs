﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller:Passenger
    {
        public String HealthInformation { get; set; }
        public String Nationality { get; set; }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("im traveller");
        }

    }
}
