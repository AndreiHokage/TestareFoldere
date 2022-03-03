using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgencies_NET.model
{
    public class Employee : IIdentifiable<int>
    {
        private int ID;

        public string Username { set; get; }

        public string Password { set; get; }

        public Employee(int ID, string username, string password)
        {
            this.ID = ID;
            Username = username;
            Password = password;
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
            return ID + ";" + Username + ";" + Password;
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
