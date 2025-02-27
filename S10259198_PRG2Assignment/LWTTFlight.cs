﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10259198_PRG2Assignment
{
    internal class LWTTFlight : Flight
    {
        public double RequestFee { get; set; }
        public LWTTFlight(string fno, string o, string dest, DateTime expecttime, string stat, double rf) : base(fno, o, dest, expecttime, stat)
        {
            RequestFee = rf;
        }

        public double CalculateFees()
        {
            

            double fees = 0;
            //Arriving flight fee
            if (Destination == "Singapore (SIN)")
            {
                fees += 500;
            }

            //Departure flight fee + Boarding gate base fee
            if (Origin == "Singapore (SIN)")
            {
                fees += 800; //departure
                fees += 300; //boarding gate
            }

            RequestFee = 500;

            return fees + RequestFee;

        }

        public override string ToString()
        {
            return $"{FlightNo}, {Origin}, {Destination}, {ExpectedTime}, {Status}, Request Fee: {RequestFee}";
        }
    }
}
