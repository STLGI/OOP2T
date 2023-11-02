using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2T
{
	internal class Owner
	{
		private readonly List<Vehicle> garage = new();

		public Owner(List<Vehicle> garage) {
			this.garage = garage;
		}

		public void AddVehicle(Vehicle vehicle)
		{
			garage.Add(vehicle);
		}
		public void ShowVehicles()
		{
			for(int i = 0; i < garage.Count; i++) {
				if (garage[i] is Plane)
				{
					Console.WriteLine("Самолет \nВысота: " + ((Plane)garage[i]).Height + "\nПассажиры: " + ((Plane)garage[i]).Passengers +
						"\nx: " + garage[i].X + "\ny:" + garage[i].Y + "\nЦена: " + garage[i].Price + "\nСкорость: " + garage[i].Speed +
						"\nГод выпуска: " + garage[i].YOI
						); 

				}
				if (garage[i] is Car)
				{
					Console.WriteLine("Машина \nx: " + garage[i].X + "\ny:" + garage[i].Y + "\nЦена: " + garage[i].Price + "\nСкорость: " + garage[i].Speed +
						"\nГод выпуска: " + garage[i].YOI
						);

				}
				if (garage[i] is Ship)
				{
					Console.WriteLine("Корабль \nПорт: " + ((Ship)garage[i]).Port + "\nПассажиры: " + ((Ship)garage[i]).Passengers +
						"\nx: " + garage[i].X + "\ny:" + garage[i].Y + "\nЦена: " + garage[i].Price + "\nСкорость: " + garage[i].Speed +
						"\nГод выпуска: " + garage[i].YOI
						);

				}
			}
		}

	}
}
