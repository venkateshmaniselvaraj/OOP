public sealed class Lorry : HeavyMotorVehicle
{
     public Lorry(string regNumber, string mfDate, DateTime insRenDate, DateTime serviceDate, string driverName, string cleanerName)
         : base(regNumber, mfDate, "Lorry", insRenDate, serviceDate, driverName, cleanerName)
     {
        //Polymorphism
     }

    public override int CalculateDistanceItCanTravel(int fuelInLitres)
    {
        return fuelInLitres * 7;
    }

}
