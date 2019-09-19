using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public  class MotorCycle: Vehicle
    {
        public MotorCycle(string licensePlate, bool broBizzDiscount = false) : base(licensePlate, broBizzDiscount)
        {
            LicensePlate = licensePlate;
            BroBizz = broBizzDiscount;
            VehicleType = "Motor Cycle";
            Price = 125;
        }
    }
}
