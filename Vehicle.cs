using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP2T
{
	class VehicleException : Exception
	{
		public VehicleException(string message) :base(message){ }
	}
	public interface IMovable
	{
		double X { get; set; }
		double Y { get; set; }
		double Price { get; set; }
		int Speed { get; set; }
		int YOI { get; set; }
		void ShowInfo();
	}
	public abstract class Vehicle : IMovable
	{
		private double _x, _y, _price;
		private int _speed, _yOI;

		public double X { get; set; }
		public double Y { get; set; }
		public double Price { get { return _price; } set { 
				if (value < 0) throw new VehicleException("Цена не может быть отрицательной!");
				else _price = value;  } }
		public int Speed { get { return _speed; } set { 
				if (value < 0) throw new VehicleException("Скорость не может быть отрицательной!");
				else _speed = value;  } }
		public int YOI { get; set; }

		public Vehicle(double x, double y, double price, int speed, int yoI) { 
			X = x;
			Y = y;
			Price = price;
			Speed = speed;
			YOI = yoI;
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

		public float Height { get { return _height; } set { 
				if (value < 0) throw new VehicleException("Высота не может быть отрицательной!");
				else _height = value;  } }
		public int Passengers { get { return _passengers; } set { 
				if (value < 0) throw new VehicleException("Число пассажиров не может быть отрицательным!");
				else _passengers = value;  } }
		
		public Plane(float height, int passengers, double x, double y, double price, int speed, int yOI) : base(x, y, price, speed, yOI)
		{
			Height = height;
			Passengers = passengers;
		}
		public override void ShowInfo()
		{
			Console.WriteLine("	Самолет: \nВысота: " + Height + "\nПассажиры: " + Passengers);
			base.ShowInfo();
		}
	}
	public class Car : Vehicle
	{
		public Car(double x, double y, double price, int speed, int yOI):base(x, y, price, speed, yOI)
		{
			
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

		public int Passengers { get { return _passengers; } set { 
				if (value < 0) throw new VehicleException("Число пассажиров не может быть отрицательным!");
				else _passengers = value;  } }
		public string? Port { get; set; }
		public Ship(int passengers, string? port, double x, double y, double price, int speed, int yOI) : base(x, y, price, speed, yOI)
		{
			Passengers = passengers;
			Port = port;
		}
		public override void ShowInfo()
		{
			Console.WriteLine("	Корабль: \nПассажиры: " + Passengers + "\nПорт: " + Port);
			base.ShowInfo();
		}
	}

}
