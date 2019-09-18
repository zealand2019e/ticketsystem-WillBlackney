using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Vehicle
    {
        // Variables
        public string licensePlate;
        public string vehicleType;
        public DateTime date;
        public double price;

        // Properties
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string VehicleType
        {
            get { return vehicleType; }
            set { VehicleType = value; }
        }

        public string LicensePlate
        {
            get { return licensePlate; }
            set
            {
                if(value.Length > 7)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    licensePlate = value;
                }                
            }
        }

        // Constructor

        public Vehicle(string licensePlate)
        {
            LicensePlate = licensePlate;
        }

    }
}
