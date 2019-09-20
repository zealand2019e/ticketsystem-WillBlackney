using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace OresundBronnLibrary
{
    public class Car : Vehicle
    {
        /// <summary>
        /// This is the car constructor
        /// </summary>
        /// <param name="licensePlate">licenseplate of the car, may not extend 7 char</param>
        /// <param name="broBizzDiscount">discount if you have a broBizz</param>
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
