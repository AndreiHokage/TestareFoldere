using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencies_NET.model
{
    public class Flight : IIdentifiable<int>
    {
        private int ID; 

        public string Destination { set; get; }

        public DateTime Departure { set; get; }

        public string Airport { set; get; }

        public int AvailableSeats { set; get; }

        public Flight(int ID, string destination, DateTime departure, string airport, int availableSeats)
        {
            this.ID = ID;
            Destination = destination;
            Departure = departure;
            Airport = airport;
            AvailableSeats = availableSeats;
        }

        public int getID()
        {
            return ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public override string ToString()
        {
            return ID + ";" + Destination + ";" + Departure + ";" + Airport + ";" + AvailableSeats;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
