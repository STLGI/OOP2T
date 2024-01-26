using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace OOP2T
{
	internal class Program
	{  
		static void Main()
		{
			try { 
				Plane plane1 = new(10000, 200, 1243.5, 653.1, 1000000.5, 400, 2012, "Просто самолет");
				Car car1 = new(243.1, 639.5, 100000.3, 151, 1970, "Dodge Charger R/T");
				Ship ship1 = new(600, "Port of Baltimore", 54873.5, 613.5, 10000000.5, 100, 2013, "Беда");
				Owner<Vehicle> businessman = new(new List<Vehicle> { plane1, car1 });
				businessman.AddVehicle(ship1);
				businessman.ShowVehicles(businessman.GetGarage());
				var yearGroup = businessman.GroupByYear();
				Console.WriteLine("\nТранспорт, сгруппированный по году выпуска: ");
				foreach (var speed in yearGroup)
				{
					Console.WriteLine("\n" + speed.Key);

					foreach (var vehicle in speed)
					{
						Console.WriteLine(vehicle.Name);
					}
				}
				var filtered = businessman.Filter("Speed", 110);
				Console.WriteLine("\nТранспорт с максимальной скоростью более 110: ");
				foreach (var vehicle in filtered)
				{
					Console.WriteLine(vehicle.Name);
				}
				var indexatorTest = businessman[2000, 2024];
				Console.WriteLine("\nТранспорт с 2000 по 2024 годы выпуска: ");
				foreach (var vehicle in indexatorTest) {
					Console.WriteLine(vehicle.Name);
				}
			}
			catch (VehicleException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch
			{
				Console.WriteLine("Произошла непредвиденная ошибка");
			}

			
		}
	}
}