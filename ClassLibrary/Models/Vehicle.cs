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
        public bool broBizz;

        // Properties
        public double Price
        {
            get
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    if (BroBizz)
                    {
                        return (price * 0.80) * 0.95;
                    }
                    else
                    {
                        return price * 0.95;
                    }
                }
                
                else
                {
                    if (BroBizz)
                    {
                        return price * 0.95;
                    }
                    else
                    {
                        return price;
                    }
                    
                }
                
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
                if(value.Length > 7)
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
