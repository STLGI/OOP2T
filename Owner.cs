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
				garage[i].ShowInfo();
				}
			}
		}

	}
