public class Vehicle
{
    public string RegistrationNumber;
    public string ManufacturedDate;
    public string VehicleType;
    public string InsuranceRenewalDate;
    public bool IsActive;

    public Vehicle(string regNumber, string mfDate, string vt, string insRenDate)
    {
        this.RegistrationNumber = regNumber;
        this.ManufacturedDate = mfDate;
        this.VehicleType = vt;
        this.InsuranceRenewalDate = insRenDate;
        this.IsActive = true;
    }
}
