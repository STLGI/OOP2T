using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2T
{
	internal class Owner<TVehicle> where TVehicle : Vehicle
	{
		private List<TVehicle> garage = new();

		public Owner(List<TVehicle> garage) {
			this.garage = garage;
		}

		public void AddVehicle(TVehicle vehicle)
		{
			garage.Add(vehicle);
		}

		public List<TVehicle> GetGarage()
		{
			return garage;
		}

		public void ShowVehicles(List<Vehicle> garage)
		{
			for (int i = 0; i < garage.Count; i++) {
				garage[i].ShowInfo();
			}
		}
		public List<TVehicle> Filter(string fieldName, double value)
		{

			switch (fieldName)
			{
				case "Price":
					return garage.Where(p => p.Price > value).ToList();
				case "Speed":
					return garage.Where(p => p.Speed > value).ToList();
				case "YOI":
					return garage.Where(p => p.YOI > value).ToList();
				default:
					Console.WriteLine("Введенный вами параметр не входит в список поддерживаемых данным методом.");
					return garage;
			}
		}
		public IEnumerable<IGrouping<int, TVehicle>> GroupByYear()
		{
			return garage.GroupBy(p => p.YOI);
		}
		public List<TVehicle> this[int startYear, int endYear]
		{
			get
			{
				return garage.Where(p => p.YOI <= endYear && p.YOI >= startYear).ToList();
			}
		}
		}
	internal class PlaneOwner<TVehicle> : Owner<TVehicle> where TVehicle : Plane
	{
		public PlaneOwner(List<TVehicle> garage) : base(garage)
		{
			
		}
	}

	internal class CarOwner<TVehicle> : Owner<TVehicle> where TVehicle : Car
	{
		public CarOwner(List<TVehicle> garage) : base(garage)
		{

		}
	}

	internal class ShipOwner<TVehicle> : Owner<TVehicle> where TVehicle : Ship
	{
		public ShipOwner(List<TVehicle> garage) : base(garage)
		{

		}
	}

}
