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
        public List<Booth> BoothsMaster { get; set; }
        public List<Booth> BoothsInUse { get; set; }
        public List<Booth> BoothsAvailable { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="address"></param>
        /// <param name="numberOfSpots"></param>
        public ParkingLot(int id, string address, int numberOfSpots)
        {
            Id = id;
            Address = address;
            NumberOfSpots = numberOfSpots;
            BoothsMaster = new List<Booth>();
            BoothsAvailable = new List<Booth>();
            BoothsInUse = new List<Booth>();
        }

        /// <summary>
        /// Add's a booth to the booth list
        /// Takes a booth obj as parameter
        /// </summary>
        /// <param name="booth"></param>
        public void AddBooth(Booth booth)
        {
            BoothsMaster.Add(booth);
        }

        /// <summary>
        /// Deletes a booth in the booth list
        /// Takes an int (the index in the list) as parameter
        /// </summary>
        /// <param name="id"></param>
        public void DeleteBooth(int id)
        {
            if (BoothsMaster.Any(booth => booth.Id != id)) return;
            BoothsMaster.RemoveAt(id);
            //foreach (var booth in BoothsMaster)
            //{
            //    if (booth.Id == id)
            //    {
                    
            //    }
            //}
        }

        /// <summary>
        /// Moves a booth from the 'available' list to the 'InUse' list.
        /// takes a booth as parameter.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool TakeBooth(Booth b)
        {
            if (BoothsAvailable.All(booth => booth != b)) return false;
            BoothsInUse.Add(b);
            BoothsAvailable.Remove(b);
            return true;
        }

        /// <summary>
        /// Moves a booth from 'InUse' list to 'Available' list.
        /// Takes a booth as parameter.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool ReleaseBooth(Booth b)
        {
            if (BoothsInUse.All(booth => booth != b)) return false;
            BoothsAvailable.Add(b);
            BoothsInUse.Remove(b);
            return true;
        }

        /// <summary>
        /// ToString Override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Address)}: {Address}, {nameof(NumberOfSpots)}: {NumberOfSpots}";
        }
    }
}
