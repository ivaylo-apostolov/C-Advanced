using System;
using System.Collections.Generic;
using System.Text;

namespace AbsAndInterface
{
    public abstract class Animal
    {
        protected Animal(string name)
        {
            this.Name = name;
        }

        public string Hunting()
        {
            return "I'm hunting...";
        }

        public string Name { get; set; }

        public abstract string Sleeping();
    }
}
