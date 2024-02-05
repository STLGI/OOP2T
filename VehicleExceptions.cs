using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2T
{
	class VehicleException : Exception
	{
		public VehicleException(string message) : base(message) { }
	}

}
