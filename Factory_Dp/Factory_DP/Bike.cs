using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP
{
	//Creating second child class of IVehicle interface class 
	internal class Bike : IVehicle
	{
		// Creating private read only variable with int return type to initialize some value which is not going to change, if we are using readonly var

		private readonly int _wheels = 2;

		// creating constructor and intializing the value to the readonly variable (ctor tap so constructor will create)

		public Bike()
		{
			// this keyword refers to current object 
			this._wheels = 2;
		}
		public int NumberofWheels()
		{
			return this._wheels;
		}

		public string VehicleType()
		{
			return "Bike Class";
		}
	}
}
