using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// input from user which type of vehilce data want to get
			Console.WriteLine("Choose the vehicle type to get details :");
			// Get into one variable
			string userInput = Console.ReadLine();
			// create obj for Ivehicle interface by passing arg into VehilceFactory class inside getvehicle method 
			IVehicle Object1 = VehicleFactory.GetVehicle(userInput);
			// Show output to the user by abstract method using object of interface of same
			Console.WriteLine("Vehicle Type is : " + Object1.VehicleType());
			Console.WriteLine("No of Wheels are : " + Object1.NumberofWheels());
			// To stay on 
			Console.ReadLine();
		}
	}
}
