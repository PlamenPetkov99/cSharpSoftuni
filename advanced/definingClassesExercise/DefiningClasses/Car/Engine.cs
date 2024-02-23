using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DefiningClasses
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine()
        {
            //Efficiency = "n/a";
            //Displacement = int.MinValue;
        }

        public Engine(string model, int power)
            : this()
        {
            Model = model;
            Power = power;
            Efficiency = "n/a";
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }


        public int Power
        {
            get { return power; }
            set { power = value; }
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
            sb.AppendLine($"Power: {Power}");
            if (displacement == 0)
            {
                sb.AppendLine($"Displacement: n/a");

            }
            else
            {
                sb.AppendLine($"Displacement: {Displacement}");

            }
            sb.AppendLine($"Efficiency: {Efficiency}");


            return sb.ToString().TrimEnd();
        }
    }
}
