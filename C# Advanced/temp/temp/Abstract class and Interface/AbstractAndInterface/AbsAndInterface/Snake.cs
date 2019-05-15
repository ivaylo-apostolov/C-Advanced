using System;
using System.Collections.Generic;
using System.Text;

namespace AbsAndInterface
{
    public class Snake : Animal
    {
        public Snake(string name) : base(name)
        {
        }

        public override string Sleeping()
        {
            return "Snake is sleeping .... zzzz";
        }
    }
}
