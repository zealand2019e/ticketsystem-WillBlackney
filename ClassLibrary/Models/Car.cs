using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Car: Vehicle
    {              
        public Car(string licensePlate) : base(licensePlate)
        {
            LicensePlate = licensePlate;
            VehicleType = "Car";
            Price = 240;
        }

    }
}
