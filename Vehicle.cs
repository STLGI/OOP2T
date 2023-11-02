using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2T
{
	public abstract class Vehicle
	{
		private double _x, _y, _price;
		private int _speed, _yOI;

		public double X { get { return _x; } set { _x = value; } }
		public double Y { get { return _y; } set { _y = value; } }
		public double Price { get { return _price; } set { _price = value; } }
		public int Speed { get { return _speed; } set { _speed = value; } }
		public int YOI { get { return _yOI; } set { _yOI = value; } }

	}
	public class Plane : Vehicle
	{
		private float _height;
		private int _passengers;

		public float Height { get { return _height; } set { _height = value; } }
		public int Passengers { get { return _passengers; } set { _passengers = value; } }

		public Plane(float height, int passengers, double x, double y, double price, int speed, int yOI)
		{
			Height = height;
			Passengers = passengers;
			X = x;
			Y = y;
			Price = price;
			Speed = speed;
			YOI = yOI;
		}
	}
	public class Car : Vehicle
	{
		public Car(double x, double y, double price, int speed, int yoI)
		{
			X = x;
			Y = y;
			Price = price;
			Speed = speed;
			YOI = yoI;
		}
	}
	public class Ship : Vehicle
	{
		private int _passengers; 
		private string? _port;

		public int Passengers { get { return _passengers; } set { _passengers = value; } }
		public string? Port { get { return _port; } set { _port = value; } }
		public Ship(int passengers, string? port, double x, double y, double price, int speed, int yOI)
		{
			Passengers = passengers;
			Port = port;
			X = x;
			Y = y;
			Price = price;
			Speed = speed;
			YOI = yOI;
		}
	}

}
