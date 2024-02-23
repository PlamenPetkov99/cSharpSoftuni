using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DefiningClasses
{
    public class Car
    {
		private string model;
		private Engine engine;
		private int weight;
		private string color;

        public Car(string model , Engine engine)
        {
			Model = model;
			Engine = engine;
			Color = "n/a";
        }
        public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public Engine Engine
		{
			get { return engine; }
			set { engine = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{Model}:");
			sb.AppendLine(Engine.ToString());
            if (Weight == 0)
            {
                sb.AppendLine($"Weight: n/a");

            }
            else
            {
                sb.AppendLine($"Weight: {Weight}");

            }
			sb.AppendLine($"Color: {Color}");

            return sb.ToString().TrimEnd();
        }
    }
}
