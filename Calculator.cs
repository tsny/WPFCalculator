using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalculator
{
    public enum Operand
    {
        addition,
        subtraction, 
        multiplication,
        division,
        power
    }

    class Calculator
    {
        public string inputString;

        public float previousInput;
        public float currentInput = 0;

        public Operand currentOperand;

        public bool currentInputHasDecimal;
        public bool hasInput;

        public void InputDigit(float digit)
        {
            inputString += digit;
            currentInput = float.Parse(inputString);
        }

        public void InputDecimal()
        {
            if (currentInputHasDecimal) return;

            inputString += ".";
            currentInputHasDecimal = true;
        }

        public void InputOperand(Operand operand)
        {

        }
    }
}
