﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10259198_PRG2Assignment
{
    internal class Terminal
    {
        public string TerminalName { get; set; }
        public Dictionary <string,Airline> Airlines { get; set; }
        public Dictionary <string,Flight> Flights { get; set; }
        public Dictionary <string,BoardingGate> BoardingGates { get; set; }
        public Dictionary <string,double> GateFees { get; set; }

        public Terminal (string tn)
        {
            Airlines = new Dictionary<string, Airline>();
            Flights = new Dictionary<string, Flight>();
            BoardingGates = new Dictionary<string, BoardingGate>();
            GateFees = new Dictionary<string, double>();
        }

        //todo : AddAirline, AddBoardingGate, GetAirlineFromFlight, PrintAirlineFees
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
