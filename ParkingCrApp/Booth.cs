using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCrApp
{
    class Booth
    {
        public int Id { get; set; }
        public int Nummer { get; set; }
        public string Parkeringsplads { get; set; }

        
        public Booth(int id, int nummer, string parkeringsplads)
        {
            Id = id;
            Nummer = nummer;
            Parkeringsplads = parkeringsplads;
        }

    }
}
