using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> data;

        public Repository()
        {
            this.data = new Dictionary<int, Person>();
            this.Counter = 0;
        }

        public int Counter
        {
            get
            {
                return data.Count;
            }
            set
            {
                this.Counter = value;
            }
        }

        public void Add(Person person)
        {
            data[Counter++] = person;
        }

        public Person Get(int id)
        {
            return data[id];
        }

        public bool Update(int id, Person newPerson)
        {
            if (data.ContainsKey(id))
            {
                data[id] = newPerson;
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            if (data.ContainsKey(id))
            {
                data.Remove(id);
                return true;
            }

            return false;
        }
    }
}
