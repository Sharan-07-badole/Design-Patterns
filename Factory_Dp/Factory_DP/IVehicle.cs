using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP
{
	//First we are creating interface
	// becuase Interface is nothing but it only accepts the abstract methods , so we can create only abstract methos inside interface
	internal interface IVehicle
	{
		// creating abstract methods
		// abstract methos are nothing but which has only method declaration but not defination , and
		// the defination of body is going to de write inside child class by method (we are creating two child class i.e car,bike
		int NumberofWheels();
		string VehicleType();
	}
}
