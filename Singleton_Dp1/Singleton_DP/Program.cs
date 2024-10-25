using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_DP
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// Here this is another class , from this class now we are trying to create the instance of that Singleton Class,
			// requesting the singleton class instance that we want to use the instance of class
			MyClass obj1 = MyClass.GetInstance();  
			MyClass obj2 = MyClass.GetInstance();
			MyClass obj3 = MyClass.GetInstance();
			// Here for every obj1, obj2 ,obj3 that returns the same instance that is named as instance , so not like every objs have different instnace

		}
	}
}
