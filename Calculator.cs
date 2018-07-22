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
        public Input currentInput;
        public Input previousInput;

        public Operand currentOperand;

        public bool HasInput
        {
            get
            {
                return currentInput.HasDefaultValue == false;
            }
        }

        public Calculator()
        {
            currentInput = new Input();
        }

        public void Clear()
        {
            currentInput = new Input();
            previousInput = null;
        }

        public void InputOperand(Operand operand)
        {
            previousInput = currentInput;
            currentOperand = operand;
        }
    }
}
