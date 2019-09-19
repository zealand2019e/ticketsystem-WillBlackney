using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Car: Vehicle
    {              
        public Car(string licensePlate, bool broBizzDiscount = false) : base(licensePlate, broBizzDiscount)
        {
            LicensePlate = licensePlate;
            BroBizz = broBizzDiscount;
            VehicleType = "Car";
            Price = 240;
        }

    }
}
