using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Tire
    {
		private int age;
		private double pressure;
		
		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
        public Tire(double pressure , int age)
        {
			Pressure = pressure;
			Age = age;
        }


    }
}
