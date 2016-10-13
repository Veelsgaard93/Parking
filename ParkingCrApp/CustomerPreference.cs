using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCrApp
{
    class CustomerPreference
    {
        public ParkingLot parkingLot { get; set; }
        public Booth booth { get; set; }

        public CustomerPreference(ParkingLot parkingLot, Booth booth)
        {
            this.parkingLot = parkingLot;
            this.booth = booth;
        }

        public override string ToString()
        {
            return $"parkingLot: {parkingLot}, booth: {booth}";
        }
    }
}
