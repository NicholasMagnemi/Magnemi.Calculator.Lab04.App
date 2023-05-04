using System;

namespace Magnemi.Calculator.Lab04.App
{
    public class SixFunctions
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private String operation = "";

        public SixFunctions(String equation)
        {
            setOperation(equation);

            setFirstNumber(equation);

            setSecondNumber(equation);
        }

        public bool setFirstNumber(string a)
        {
            InputValidation validation = new InputValidation();

            String temp = a.Substring(0, a.IndexOf(operation));

            if (temp.Contains('\u207b'))
            {
                Console.WriteLine(temp);
                temp = temp.Replace('\u207b', '-');
            }

            if (temp.Contains('%'))
            {
                temp = temp.Remove(temp.LastIndexOf('%'));
                temp = (Convert.ToDouble(temp) / 100.0).ToString();
            }

            if (validation.containsNoNumbers(temp))
            {
                firstNumber = Convert.ToDouble(temp);
                return true;
            }
            return false;
        }

        public String getFirstNumber()
        {
            return firstNumber.ToString();
        }

        public bool setSecondNumber(string a)
        {
            InputValidation validation = new InputValidation();

            String temp;

            if (operation == "mod")
            {
                temp = a.Substring(a.IndexOf(operation) + 3);
            }
            else
            {
                temp = a.Substring(a.IndexOf(operation) + 1);
            }

            if (temp.Contains('\u207b'))
            {
                temp = temp.Replace('\u207b', '-');
            }

            if (temp.Contains('%'))
            {
                temp = temp.Remove(temp.LastIndexOf('%'));
                temp = (Convert.ToDouble(temp) / 100.0).ToString();
            }

            if (validation.containsNoNumbers(temp))
            {
                secondNumber = Convert.ToDouble(temp);
                return true;
            }
            return false;
        }

        public String getSecondNumber()
        {
            return secondNumber.ToString();
        }

        public bool setOperation(string a)
        {
            if (a.Contains('+'))
            {
                operation = "+";
                return true;
            }
            else if (a.Contains('-'))
            {
                operation = "-";
                return true;
            }
            else if (a.Contains('*'))
            {
                operation = "*";
                return true;
            }
            else if (a.Contains('\u005C'))
            {
                operation = "\u005C";
                return true;
            }
            else if (a.Contains('/'))
            {
                operation = "/";
                return true;
            }
            else if (a.Contains("mod"))
            {
                operation = "mod";
                return true;
            }
            else
            {
                return false;
            }
        }

        public String getOperation()
        {
            return operation.ToString();
        }

        public String functionSelector()
        {
            switch (operation)
            {
                case "+":
                    return addTwoNumbersFunction();
                case "-":
                    return subtractTwoNumbersFunction();
                case "*":
                    return multiplyTwoNumbersFunction();
                case "\u005C":
                    return divideTwoIntegersFunction();
                case "/":
                    return divideTwoNumbersFunction();
                case "mod":
                    return modulusOfTwoNumbersFunction();
                default:
                    return "Error";
            }
        }

        public String addTwoNumbersFunction()
        {
            return (firstNumber + secondNumber).ToString();
        }

        public String subtractTwoNumbersFunction()
        {
            return (firstNumber - secondNumber).ToString();
        }

        public String divideTwoIntegersFunction()
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                return "Cannot divide by zero";
            }
            return (Convert.ToInt32(firstNumber) / Convert.ToInt32(secondNumber)).ToString();
        }

        public String divideTwoNumbersFunction()
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                return "Cannot divide by zero";
            }
            return (firstNumber / secondNumber).ToString();
        }

        public String multiplyTwoNumbersFunction()
        {
            return (firstNumber * secondNumber).ToString();
        }

        public String modulusOfTwoNumbersFunction()
        {
            return (firstNumber % secondNumber).ToString();
        }

        public String percentageConverter(String temp)
        {
            if (temp.Contains('%'))
            {
                return (Convert.ToDouble(temp) / 100.0).ToString();
            }
            return temp;
        }

    }

}