using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Customer
    {
        // Variables
        private string name;
        private int iD;
        private List<TravelEvent> myTrips;
      
        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public List<TravelEvent> MyTrips
        {
            get { return myTrips; }
            set { myTrips = value; }
        }

        // Constructor
        public Customer(string name, int iD)
        {
            Name = name;
            ID = iD;
        }
    }
}
