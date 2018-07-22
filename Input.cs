using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalculator
{
    class Input
    {
        public bool HasDecimal
        {
            get
            {
                return stringValue.ToString().Contains(".");
            }
        }
        public bool HasDefaultValue
        {
            get
            {
                return stringValue == "0";
            }
        }

        public string stringValue = "0";
        public float floatValue = 0;

        public void AddDecimal()
        {
            if (HasDecimal) return;

            stringValue += ".";
        }

        public void AddDigit(int digit)
        {
            if (stringValue == "0" && digit == 0) return;

            if (stringValue == "0")
            {
                stringValue = digit.ToString();
                return;
            }

            stringValue += digit.ToString();
        }

        public void Negate()
        {
            floatValue = -floatValue;
        }
    }
}
