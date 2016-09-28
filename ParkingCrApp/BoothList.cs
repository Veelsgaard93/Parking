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
        /// <summary>
        /// Add's a booth to the booth list
        /// Takes a booth obj as parameter
        /// </summary>
        /// <param name="booth"></param>
        public void Add(Booth booth)
        {
            Booths.Add(booth);
        }
        /// <summary>
        /// Deletes a booth in the booth list
        /// Takes an int (the index in the list) as parameter
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            foreach (var booth in Booths) if (booth.Id == id) Booths.RemoveAt(id);
        }
        /// <summary>
        /// Displays all booths in the boothlist
        /// </summary>
        public void Display()
        {
            foreach (var booth in Booths) Console.WriteLine(booth.ToString());
        }
    }
}
