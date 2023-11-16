public abstract class HeavyMotorVehicle : Vehicle
{
    public string Cleaner;

    public HeavyMotorVehicle(string regNumber, string mfDate, string vt, DateTime insRenDate, DateTime serviceDate, string driverName, string cleanerName)
         : base(regNumber, mfDate, vt, insRenDate, serviceDate, driverName)
     {
          Cleaner = cleanerName;
    
       
     
     }

    public override int CalculateDistanceItCanTravel(int fuelInLitres)
    {
        return fuelInLitres * 8;
    }
}