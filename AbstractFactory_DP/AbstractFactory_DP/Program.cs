using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP
{
	interface ICar
	{
		void ManufactureCar();
	}
	interface IBike
	{
		void ManufactureBike();
	}
	// creating super factory
	interface VehicleCompany
	{
		ICar GetCar();
		IBike GetBike();
	}
	class Honda : VehicleCompany
	{
		public IBike GetBike()
		{
			return new HondaBike(); 
		}

		public ICar GetCar()
		{
			return new HondaCar();
		}
	}
	class Suzuki : VehicleCompany
	{
		public IBike GetBike()
		{
			return new SuzukiBike();
		}
		public ICar GetCar()
		{
			return new SuzukiCar();
		}
	}

	class HondaCar : ICar
	{
		public void ManufactureCar()
		{
			Console.WriteLine("Honda Car is Manufactured..");
		}
	}
	class HondaBike : IBike
	{
		public void ManufactureBike()
		{
			Console.WriteLine("Honda Bike is Manufactured..");
		}
	}
	class SuzukiCar : ICar
	{
		public void ManufactureCar()
		{
			Console.WriteLine("Suzuki Car is Manufactured..");
		}
	}
	class SuzukiBike : IBike
	{
		public void ManufactureBike()
		{
			Console.WriteLine("Suzuki Bike is Manufactured..");
		}			
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			VehicleCompany hondaCompany = new Honda();
			ICar hondaCar = hondaCompany.GetCar(); //new HondaCar()
			IBike hondaBike = hondaCompany.GetBike(); // new HondaBike()

			VehicleCompany suzukiCompany = new Suzuki();
			ICar suzukiCar = suzukiCompany.GetCar();  // new SuzukiCar()
			IBike suzukiBike = suzukiCompany.GetBike();  // new SuzukiBike()

			hondaCar.ManufactureCar();
			hondaBike.ManufactureBike();

			suzukiCar.ManufactureCar();
			suzukiBike.ManufactureBike();

			Console.ReadLine();

		}
	}
}
