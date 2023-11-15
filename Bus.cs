public sealed class Bus : HeavyMotorVehicle
{
     public Bus(string regNumber, string mfDate, DateTime insRenDate, DateTime serviceDate, string driverName, string cleanerName)
         : base(regNumber, mfDate, "Bus", insRenDate, serviceDate, driverName, cleanerName)
     {
        
     }
}



