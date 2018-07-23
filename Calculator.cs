using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalculator
{

    class Calculator
    {
        public Input currentInput;
        public Input previousInput;

        public char currentOperand;

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

        public void ParseInput(String input)
        {
            int result;

            if (int.TryParse(input, out result))
            {
                currentInput.AddDigit(result);
                return;
            }

            switch (input)
            {
                case "0":
                    currentInput.AddDigit(0);
                    break;

                case ".":
                    currentInput.AddDecimal();
                    break;

                case "C":
                    Clear();
                    break;

                case "±":
                    currentInput.Negate();
                    break;

                case "=":
                    Calculate();
                    break;

                // Operands

                case "/":
                case "*":
                case "+":
                case "-":
                    InputOperand(input[0]);
                    break;
            }
        }

        public void Clear()
        {
            currentInput = new Input();
            previousInput = null;
        }

        public void ClearEntry()
        {
            currentInput = new Input();
        }

        public void InputOperand(char operand)
        {
            if (previousInput != null)
            {
                Calculate();
            }

            previousInput = currentInput;
            currentInput = new Input();
            currentOperand = operand;
        }

        private void Calculate()
        {
            if (previousInput == null) return;

            currentInput.StringValue = ParseOperand().ToString();

            previousInput = null;
        }

        private float ParseOperand()
        {
            switch (currentOperand)
            {
                case '+':
                    return Addition();

                case '-':
                    return Subtraction();

                case '*':
                    return Multiplication();

                case '/':
                    return Division();

                default:
                    return 0;
            }
        }

        private float Addition()
        {
            return currentInput.GetFloatValue() + previousInput.GetFloatValue();
        }

        private float Subtraction()
        {
            return currentInput.GetFloatValue() - previousInput.GetFloatValue();
        }

        private float Multiplication()
        {
            return currentInput.GetFloatValue() * previousInput.GetFloatValue();
        }

        private float Division()
        {
            return currentInput.GetFloatValue() / previousInput.GetFloatValue();
        }
    }
}
