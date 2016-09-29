using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCrApp
{
    class Reservation
    {
        public static List<Reservation> Reservations;

        public int Id { get; set; }

        public ParkingLot ParkingLot { get; set; }

        public Booth Booth { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Reservation()
        {           
        }

        /// <summary>
        /// Adds a resevation to the resevation list.
        /// takes a resevation object as Parameter.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool AddResevation(Reservation r)
        {
            Reservations.Add(r);
            return true;
        }

        /// <summary>
        /// Checks if a reservation exists and removes a resevation from the resevation list.
        /// Takes an an ID(int) as parameter. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RemoveResevation(int id)
        {
            if (Reservations.Any(resevation => resevation.Id != id)) return false;
            Reservations.RemoveAt(id);
            return true;
        }
    }
}
