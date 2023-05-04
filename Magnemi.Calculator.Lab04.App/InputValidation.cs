using System;
using System.Collections.Generic;
using System.Text;

namespace Magnemi.Calculator.Lab04.App
{
    public class InputValidation
    {
        public InputValidation() { }

        public bool stringToIntValidator(string a)
        {
            try
            {
                Convert.ToInt32(a);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool containsNoNumbers(string a)
        {
            for (int count = 0; count <= a.Length - 1; count++)
            {
                if (Char.IsNumber(a[count]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}