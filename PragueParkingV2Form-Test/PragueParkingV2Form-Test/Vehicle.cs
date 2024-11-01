using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParkingV2Form_Test
{
    public abstract class Vehicle
    {
        // Enum för fordonsstorlek och typ
        public enum VehicleType
        {
            Car,
            MC,
            Bus,
            Cycle
        }

        public enum ParkingStatus
        {
            Free,
            Busy
        }
        public string RegistrationNumber { get; set; }
        public VehicleType Type { get; set; }
        public int Size { get; set; } // Storleksegenskap
        public DateTime ParkTime { get; set; }

        public Vehicle(string registrationNumber, VehicleType type, int size, DateTime parkTime)
        {
            RegistrationNumber = registrationNumber;
            Type = type;
            Size = size;
            ParkTime = parkTime;
        }
        public Vehicle(string registrationNumberOnly)
        {
            RegistrationNumber = registrationNumberOnly;
        }

        public abstract void Start();
    }
}
