using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCrApp
{
    public class Booth
    {
        public int Id { get; set; }
        public int Nummer { get; set; }
        public string Parkeringsplads { get; set; }
        public bool InUse { get; set; }

        
        public Booth(int id, int nummer, string parkeringsplads, bool inuse)
        {
            Id = id;
            Nummer = nummer;
            Parkeringsplads = parkeringsplads;
            InUse = inuse;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Nummer)}: {Nummer}, {nameof(Parkeringsplads)}: {Parkeringsplads}, {nameof(InUse)}: {InUse}";
        }
    }
}
