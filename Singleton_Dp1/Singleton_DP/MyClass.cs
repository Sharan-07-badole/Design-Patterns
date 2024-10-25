using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_DP
{
	// I havwe to make this class sealed bcoz , sinlgeton class doesnot inheritance , so to stop that we are using sealed class
	sealed class MyClass
	{
		// Fisrt we have to create private default constructor (i.e constructor with no parameters
		private MyClass() { }

		// Now we have to create an instance/ object of this class, make it private and static instance , bcoz it's going to return single instance and
		// if we private this this instance so, no class can access this instance outside the class,
		// This all we are doing because singleton design pattern requires all these conditions
		//Singleton desing pattern demands - 1.create private default constructor , 2.create private static instance , and 
		// 3. return that instance by creating private static method ,so 
		// whenever the other classes want to access the object of this class so , 
		// that this method will return the same instance to every requested class


		// Now,see what happens, if not a single class want to use instance of this class , so without any reason this class is going to create object,
		// so if object created , it take som space , so to avoid that we use if condition and if some class requested for instance then only
		// it should create the object , edit the below line and crate inside if condition 

		//private static MyClass instance = new MyClass(); 

		private static MyClass instance;

		// Now we are creating the object for "Object class" (object class = this is parent of all classes) and we are using instancelock
		// because when, we are using multithreading in our project ( threading - there is single thread for our entire project , so by using that single
		// threading , we creates multiple threading to run the class parallelly, so if two classes calls this singleton instance , so
		// there is crash happens , so to avoid that we are using "instancelock" obj og class "Object" ,
		// which holds the class until the one class complte there task
		// we are creating the instace of that class is private and static 

		private static object instanceLock = new object();

		public static MyClass GetInstance()
		{
			if (instance == null)
			{
				lock (instanceLock)
				{
					if (instance == null)
					{
						instance = new MyClass();
					}
				}
			}
			return instance;
		}
	}
}
// Now thuis is the perfect Singleton Class...