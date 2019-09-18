using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Car
    {
        // Variables
        public string licensePlate;
        public string vehicleType;
        public DateTime date;        

        // Properties
        public double Price()
        {
            return 240; 
        }

        public string VehicleType()
        {
            return "Car";
        }

    }
}
