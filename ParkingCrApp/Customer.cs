using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCrApp
{
    class Customer
    {
        public static Dictionary<Booth, int> Preferences;
        public static Dictionary<Customer, string> Notifaction;

        
        public Customer()
        {
            Preferences = new Dictionary<Booth, int>();
            Notifaction = new Dictionary<Customer, string>();
        }

        /// <summary>
        /// Adds a booth to the prefrences dictionary
        /// </summary>
        /// <param name="booth"></param>
        public void Add(Booth booth)
        {
            Preferences.Add(booth, booth.Id);
        }
        /// <summary>
        /// Removes the first matching instance from the dictionary
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var item = Preferences.First(kvp => kvp.Value == id);

            Preferences.Remove(item.Key);
        }
        /// <summary>
        /// Displays all booths in preferences
        /// </summary>
        public void Display()
        {
            foreach (var booth in Preferences) Console.WriteLine(booth.ToString());  
        }

        
    }

 
}


