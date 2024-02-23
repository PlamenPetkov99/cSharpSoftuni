using System.Text;

namespace DefiningClasses
{
    public class Person
    {
		private string name;
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

        public Person()
        {
			Name = "No name";
			Age = 1;
        }
        public Person(int age)
			:this()
        {
			Age = age;
        }
        public Person(int age , string name)
			:this(age)
        {
			Name = name;
			Age = age;
        }



    }
}
