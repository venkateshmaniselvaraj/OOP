// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Bus v1 = new Bus("TN78AR78960", "2014", new DateTime(2024,03,31), new DateTime(2024,05,31));
Bus v2 = new Bus("TN78AR7234", "2016", new DateTime(2026,03,31), new DateTime(2026,05,31));
Bus v3 = new Bus("TN78AR7234", "2018", new DateTime(2018,03,31), new DateTime(2028,05,31));

//Vehicle v4 = new Vehicle("TN78AR789sd60", "2002", "Lorry", DateTime.Parse("01-02-2024"), DateTime.Parse("0.1-05-2024"));

Console.WriteLine(v1.LastServiceDate);
Console.WriteLine(v1.NextServiceDate);
Console.WriteLine(v1.VehicleType);

Console.WriteLine("After Service");

v1.UpdateService(new DateTime(2024, 05, 31), new DateTime(2024, 06, 30));
DateTime nextService = v1.UpdateService(new DateTime(2024,05, 31), 30);

Console.WriteLine(v1.LastServiceDate);
Console.WriteLine(nextService);


