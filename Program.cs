using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace OOP2T
{
	internal class Program
	{  
		static void Main()
		{
			Plane plane1 = new(10000, 200,1243.5, 653.1, 1000000.5, 400, 2012);
			Car car1 = new(243.1, 639.5, 10000.3, 120, 1999);
			Ship ship1 = new(600, "Port of Baltimore", 54873.5, 613.5, 10000000.5, 100, 2013);
			Owner businessman = new(new List<Vehicle>{ plane1, car1 });
			businessman.AddVehicle(ship1);
			businessman.ShowVehicles();
		}
	}
}