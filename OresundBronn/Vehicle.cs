using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace OresundBronnLibrary
{
    public class Vehicle
    {
        // Variables
        public string licensePlate;
        public string vehicleType;
        public DateTime date;
        public double price;
        public bool broBizz;

        // Properties
        public virtual double Price
        {
            get
            {
                return price;
            }

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
                if (value.Length > 7)
                {
                    throw new ArgumentOutOfRangeException("Cannot set LP more then 7 characters!");
                }
                else
                {
                    licensePlate = value;
                }
            }
        }

        public bool BroBizz
        {
            get { return broBizz; }
            set { broBizz = value; }
        }

        // Constructor
        public Vehicle(string licensePlate, bool broBizzDiscount = false)
        {
            LicensePlate = licensePlate;
            BroBizz = broBizzDiscount;
        }

    }
}
