using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Models;

namespace OresundBronnLibrary
{
    public class MotorCycle : Vehicle
    {
        public MotorCycle(string licensePlate, bool broBizzDiscount = false) : base(licensePlate, broBizzDiscount)
        {
            LicensePlate = licensePlate;
            BroBizz = broBizzDiscount;
            VehicleType = "Motor Cycle";

            if (BroBizz)
            {
                Price = 73;
            }
            else
            {
                Price = 161;
            }
        }

    }
}
