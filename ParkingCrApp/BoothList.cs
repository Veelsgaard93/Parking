using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCrApp
{
    class BoothList
    {
        public static List<Booth> Booths;
        public BoothList()
        {
            Booths = new List<Booth>();
        }

        public void Add(Booth booth)
        {
            Booths.Add(booth);
        }

        public void Delete(int id)
        {
            foreach (var booth in Booths) if (booth.Id == id) Booths.RemoveAt(id);
        }

        public void Display()
        {
            foreach (var booth in Booths) Console.WriteLine(booth.ToString());
        }
    }
}
