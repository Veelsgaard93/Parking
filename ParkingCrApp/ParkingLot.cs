using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCrApp
{
    public class ParkingLot
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int NumberOfSpots { get; set; }

        public ParkingLot(int id, string address, int numberOfSpots)
        {
            Id = id;
            Address = address;
            NumberOfSpots = numberOfSpots;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Address)}: {Address}, {nameof(NumberOfSpots)}: {NumberOfSpots}";
        }
    }
}
