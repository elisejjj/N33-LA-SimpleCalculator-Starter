using System;

namespace SimpleCalculator
{
    public class InputConverter 
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            
            int converted = Convert.ToInt32(argTextInput);
            return converted;
        }
    }
}
