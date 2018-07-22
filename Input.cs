using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                return StringValue.ToString().Contains(".");
            }
        }
        public bool HasDefaultValue
        {
            get
            {
                return StringValue == "0";
            }
        }

        public string StringValue { get; set; } = "0";

        public void AddDecimal()
        {
            if (HasDecimal) return;

            StringValue += ".";
        }

        public void AddDigit(int digit)
        {
            if (StringValue == "0" && digit == 0) return;

            if (StringValue == "0")
            {
                StringValue = digit.ToString();
                return;
            }

            StringValue += digit.ToString();
        }

        public void Negate()
        {
            if (StringValue == "0") return;

            if (StringValue[0].Equals('-'))
            {
                StringValue = StringValue.Substring(1);
            }

            else
            {
                StringValue = "-" + StringValue;
            }
        }
    }
}
