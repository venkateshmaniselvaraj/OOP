public class Vehicle
{
    public string RegistrationNumber;
    public string ManufacturedDate;
    public string VehicleType;
    public DateTime InsuranceRenewalDate;
    public bool IsActive;
    public DateTime LastServiceDate;
    public DateTime NextServiceDate;

    public Vehicle(string regNumber, string mfDate, string vt, DateTime insRenDate, DateTime serviceDate)
    {
        this.RegistrationNumber = regNumber; 
        this.ManufacturedDate = mfDate;
        this.VehicleType = vt;
        this.InsuranceRenewalDate = insRenDate;
        this.IsActive = true;
        this.NextServiceDate = serviceDate;
    }

    public void UpdateService(DateTime finishedServiceDate, DateTime nextServiceDate)
    {
        LastServiceDate = finishedServiceDate;
        NextServiceDate = nextServiceDate;
      
    }
    public DateTime UpdateService(DateTime finishedServiceDate, int nextServiceDate)
    {
        LastServiceDate = finishedServiceDate;
        NextServiceDate  = LastServiceDate.AddDays(nextServiceDate);
        return NextServiceDate;
    }

}
