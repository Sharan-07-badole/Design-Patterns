using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP
{
	// Here in this class we are creating method for getting user input and returning value to the insterface
	internal class VehicleFactory
	{
		// creating public static method with interface return type

		public static IVehicle GetVehicle(string ObjType )
		{
			// creating the variable of return type class object and initializing the value to the variable is null
			IVehicle ObjectType = null;

			if (ObjType.ToLower().Equals("bike"))
			{
				// returing the new object creation of bike class if user gives input as bike  
				return ObjectType = new Bike();
			}
			else if(ObjType.ToLower().Equals("car"))
			{
				// returning the new object of car class if user input matches to car
				return ObjectType = new Car();
			}
			// if user gives any different input then it returns null value.
			return ObjectType;
		} 
	}
}
// Now call this in main class
