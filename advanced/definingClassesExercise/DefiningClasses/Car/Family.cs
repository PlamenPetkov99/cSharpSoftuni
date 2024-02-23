using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
		private List<Person> members;


		public List<Person> Members
		{
			get { return members; }
			set { members = value; }
		}
        public Family()
        {
			members = new List<Person>();
        }

        public void AddMember(Person member)
		{
			members.Add(member);
		}

		public Person GetOldestMember()
		{
			Person person = members.OrderByDescending(m => m.Age).FirstOrDefault();
			return person;
		}




    }
}
