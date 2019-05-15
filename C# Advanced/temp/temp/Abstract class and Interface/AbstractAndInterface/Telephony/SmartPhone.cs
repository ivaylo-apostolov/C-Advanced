using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class SmartPhone : ICalling, IBrowsing
    {
        private int number;

        public int Number
        {
            get
            {
                return number;
            }
            private set
            {
                if (Regex.IsMatch(value, $"[\d]")
                {
                    //Invalid number
                }
                this.number = value;
            }
        }

        public string Calling()
        {
            throw new NotImplementedException();
        }
    }
}
