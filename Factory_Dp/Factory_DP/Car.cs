using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP
{
	// creating child class of IVehilce interface class
	internal class Car : IVehicle
	{
		//we are creating private read only variable i.e this readonly we can read it only first time it takes value , once value set 
		// its not going to change and this variable value we are going to initialize inside the constructure 
		private readonly int _wheels;

	    //creating constructor which will innitialize some value, and we are initialize this value to the read only variable
		public Car()
		{ 
			this._wheels = 4;
		}
		
		// creating methods of parent class with some body which will return something back to interface methods  
         
		public int NumberofWheels()
		{
			return this._wheels;
		}

		public string VehicleType()
		{
			return "Car Class";
		}
	}
}
