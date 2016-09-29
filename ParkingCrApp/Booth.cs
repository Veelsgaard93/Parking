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
        public int Number { get; set; }
        
        public Booth(int id, int number)
        {
            Id = id;
            Number = number;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Number: {Number}";
        }
    }
}
