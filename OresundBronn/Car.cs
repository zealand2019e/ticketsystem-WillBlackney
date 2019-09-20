using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace OresundBronnLibrary
{
    public class Car : Vehicle
    {
        
        public Car(string licensePlate, bool broBizzDiscount = false) : base(licensePlate, broBizzDiscount)
        {
            LicensePlate = licensePlate;
            BroBizz = broBizzDiscount;
            VehicleType = "Car";
            if (BroBizz)
            {
                Price = 210;
            }
            else
            {
                Price = 410;
            }
        }

    }
}
