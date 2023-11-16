// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Bus b1 = new Bus("TN78AR78960", "2014", new DateTime(2024,03,31), new DateTime(2024,05,31), "A", "B");
Bus b2 = new Bus("TN78AR7234", "2016", new DateTime(2026,03,31), new DateTime(2026,05,31), "A", "B");
Bus b3 = new Bus("TN78AR7234", "2018", new DateTime(2018,03,31), new DateTime(2028,05,31), "A", "B");

Lorry l1 = new Lorry("TN78AR7234", "2018", new DateTime(2018,03,31), new DateTime(2028,05,31), "A", "B");




/**

Console.WriteLine(b1.LastServiceDate);
Console.WriteLine(b1.NextServiceDate);
Console.WriteLine(b1.VehicleType);

Console.WriteLine("After Service");

b1.UpdateService(new DateTime(2024, 05, 31), new DateTime(2024, 06, 30));
DateTime nextService = b1.UpdateService(new DateTime(2024,05, 31), 30);

Console.WriteLine(b1.LastServiceDate);
Console.WriteLine(nextService);  **/

HeavyMotorVehicle[] vehicles = new HeavyMotorVehicle[4] {b1, b2, b3, l1}; 

for(int i=0; i < vehicles.Length; i++)
{
      Console.WriteLine("______________________");
      Console.WriteLine(vehicles[i].VehicleType);
      Console.WriteLine(vehicles[i].ManufacturedDate);
      Console.WriteLine(vehicles[i].InsuranceRenewalDate);
      Console.WriteLine("Mileage:" + vehicles[i].CalculateDistanceItCanTravel(10));
}











