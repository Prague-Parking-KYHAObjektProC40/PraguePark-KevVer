using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParkingV2Form_Test
{
    public class ParkingGarage
    {
        public List<ParkingGarage> parkingGarages { get; private set; } = new List<ParkingGarage>();//kanske
        public List<Vehicle> vehicles { get; private set; } = new List<Vehicle>();//kanske
        //public List<ParkingSpot> parkingSpots { get; private set; } = new List<ParkingSpot>();//kanske

        public string RegistrationNumber;
        public int LotRow { get; set; }
        public string LotColumn { get; set; }
        public static string ErrorMessage { get; set; }
        public ParkingGarage(string lotRow, string lotColumn)
        {
            LotRow = Convert.ToInt32(lotRow);
            LotColumn = lotColumn;
        }
        public ParkingGarage(string registrationNumber) //Vid sökning
        {
            RegistrationNumber = registrationNumber;
        }
        public ParkingGarage() { } //tomt fält. tillgång till properties och metoder
        public bool IsValidVehicle(string registrationNumber, string lotRow, string lotColumn)
        {
            if (registrationNumber.Trim().Equals(""))
            {
                ErrorMessage = "Registration Nr. is Required!";
                return false;
            }
            int validRow;
            if (!int.TryParse(lotRow, out validRow) || validRow < 1 || validRow > 10)
            {
                ErrorMessage = "Valid Lot Row is Required!";
                return false;
            }
            if (lotColumn.ToUpper() != "A" && lotColumn.ToUpper() != "B" && lotColumn.ToUpper() != "C" && lotColumn.ToUpper() != "D" && lotColumn.ToUpper() != "E" &&
                lotColumn.ToUpper() != "F" && lotColumn.ToUpper() != "G" && lotColumn.ToUpper() != "H" && lotColumn.ToUpper() != "I" && lotColumn.ToUpper() != "J")
            {
                ErrorMessage = "Valid Lot Column is Required!";
                return false;
            }
            return true;
        }
        public static bool IsLotTaken(String lotRow, String lotColumn) //om plats är ledig
        {
            var isTaken = frmPragueParking.parkingGarages.Where(v => v.LotRow == Convert.ToInt32(lotRow) && v.LotColumn.ToUpper() == lotColumn.ToUpper()).Count();
            return isTaken == 0 ? false : true;
        }
        public static List<Vehicle> GetVehiclesRegNum(string registrationNum)
        {
            return frmPragueParking.vehicles.Where(v => v.RegistrationNumber == registrationNum).ToList();
        }
        public void AddVehicle(Vehicle vehicle)
        {
            frmPragueParking.vehicles.Add(vehicle);
        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            frmPragueParking.vehicles.Remove(vehicle);
        }
        public int NumParkedVehicle()
        {
            return frmPragueParking.vehicles.Count();
        }
    }
}
