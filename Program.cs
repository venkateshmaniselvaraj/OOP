// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Vehicle v1 = new Vehicle("TN78AR78960", "2012", "Bus", "31/02/2024");
Vehicle v2 = new Vehicle("TN78AR789sd60", "2002", "Lorry", "01/02/2024");
Console.WriteLine(v1.RegistrationNumber);
Console.WriteLine(v1.IsActive);
Console.WriteLine(v2.IsActive);
v1.IsActive = false;
Console.WriteLine(v1.IsActive);
Console.WriteLine(v2.IsActive);
