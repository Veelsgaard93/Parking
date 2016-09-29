using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCrApp
{
    class Customer
    {
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        private List<CustomerPreference> Preferences;
        //public static Dictionary<Customer, string> Notifaction;
        
        public Customer(int customerId, string firstName, string lastName, string address, string email, string phone)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            Phone = phone;
            Preferences=new List<CustomerPreference>();
        }

        public void AddPreference(ParkingLot p, Booth b)
        {
            Preferences.Add(new CustomerPreference(p,b));
        }

        public bool DeletePreference(ParkingLot p, Booth b)
        {
            if (!Preferences.Any(cp => cp.parkingLot == p && cp.booth == b)) return false;
            Preferences.Remove(new CustomerPreference(p, b));
            return false;
        }

        public void DisplayPreference()
        {

        }
    }
}


