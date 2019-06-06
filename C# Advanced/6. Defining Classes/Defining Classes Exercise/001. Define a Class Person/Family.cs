using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> People;

        public Family()
        {
            People = new List<Person>();
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public List<Person> Sort(List<Person> list)
        {
            return list.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
        }
    }
}
