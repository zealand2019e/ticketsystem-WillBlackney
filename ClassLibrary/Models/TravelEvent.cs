using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class TravelEvent
    {
        // Variables
        private Customer customer;
        private DateTime travelDate;
        private Vehicle vehicleUsed;

        // Properties
        public Customer Customer { get => customer; set => customer = value; }
        public DateTime TravelDate { get => travelDate; set => travelDate = value; }
        public Vehicle VehicleUsed { get => vehicleUsed; set => vehicleUsed = value; }

        // Constructor
        public TravelEvent(Customer customer, DateTime travelDate, Vehicle vehicleUsed)
        {
            Customer = customer;
            TravelDate = travelDate;
            VehicleUsed = vehicleUsed;
        }
        

        
    }
}
