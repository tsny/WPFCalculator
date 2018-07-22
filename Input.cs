using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalculator
{
    class Input
    {
        public float FloatValue { get; set; }

        public string StringValue
        {
            get
            {
                return FloatValue.ToString("R");
            }

            set
            {
                stringValue = value;
                FloatValue = float.Parse(value);
            }
        }

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

        private string stringValue;

        public Input()
        {
            FloatValue = 0;
        }

        public void AddDecimal()
        {
            if (HasDecimal) return;

            StringValue += ".";
        }

        public void AddDigit(int digit)
        {
            if (FloatValue == 0 && digit == 0) return;

            if (digit == 0)
            {
                StringValue = digit.ToString();
            }

            else
            {
                StringValue += digit.ToString();
            }
        }

        public void Negate()
        {
            FloatValue = -FloatValue;
        }
    }
}
