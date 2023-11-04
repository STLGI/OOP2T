using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2T
{
	public abstract class Vehicle
	{
		private double _x, _y, _price;
		private int _speed, _yOI;

		public double X { get; set; }
		public double Y { get; set; }
		public double Price { get; set; }
		public int Speed { get; set; }
		public int YOI { get; set; }

		public Vehicle(double x, double y, double price) { 
			X = x;
			Y = y;
			Price = price;
		}

		public virtual void ShowInfo()
		{
			Console.WriteLine("Координата x: " + X + "\nКоордината y: " + Y + "\nЦена: " + Price + "\nСкорость: " + Speed +
				"\nГод выпуска: " + YOI);
		}

	}
	public class Plane : Vehicle
	{
		private float _height;
		private int _passengers;

		public float Height { get; set; }
		public int Passengers { get; set; }
		
		public Plane(float height, int passengers, double x, double y, double price, int speed, int yOI) : base(x, y, price)
		{
			Height = height;
			Passengers = passengers;
			Speed = speed;
			YOI = yOI;
		}
		public override void ShowInfo()
		{
			Console.WriteLine("	Самолет: \nВысота: " + Height + "\nПассажиры: " + Passengers);
			base.ShowInfo();
		}
	}
	public class Car : Vehicle
	{
		public Car(double x, double y, double price, int speed, int yoI):base(x, y, price)
		{
			Speed = speed;
			YOI = yoI;
		}
		public override void ShowInfo()
		{
			Console.WriteLine("	Машина: ");
			base.ShowInfo();
		}
	}
	public class Ship : Vehicle
	{
		private int _passengers; 
		private string? _port;

		public int Passengers { get; set; }
		public string? Port { get; set; }
		public Ship(int passengers, string? port, double x, double y, double price, int speed, int yOI) : base(x, y, price)
		{
			Passengers = passengers;
			Port = port;
			Speed = speed;
			YOI = yOI;
		}
		public override void ShowInfo()
		{
			Console.WriteLine("	Корабль: \nПассажиры: " + Passengers + "\nПорт: " + Port);
			base.ShowInfo();
		}
	}

}
