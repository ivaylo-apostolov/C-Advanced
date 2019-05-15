using System;
using System.Collections.Generic;
using System.Text;

namespace AbsAndInterface
{
    public class Horse : Animal
    {
        public Horse(string name) : base(name)
        {
        }

        public override string Sleeping()
        {
            return "Horse is sleeping.... zzzzz";
        }
    }
}
