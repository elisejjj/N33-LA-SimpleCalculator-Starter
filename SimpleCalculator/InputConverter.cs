using System;

namespace SimpleCalculator
{
    public class InputConverter 
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            
            double converted = Convert.ToDouble(argTextInput);
            return converted;
        }
    }
}
