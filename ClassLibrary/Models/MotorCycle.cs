using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public  class MotorCycle: Vehicle
    {
        public MotorCycle(string licensePlate) : base(licensePlate)
        {
            LicensePlate = licensePlate;
            VehicleType = "Motor Cycle";
            Price = 125;
        }
    }
}
