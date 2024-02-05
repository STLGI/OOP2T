using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2T
{
	public interface IMovable
	{
		double X { get; set; }
		double Y { get; set; }
		double Price { get; set; }
		int Speed { get; set; }
		int YOI { get; set; }

		string Name { get; set; }
		void ShowInfo();
	}
}
