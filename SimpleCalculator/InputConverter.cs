using System;

namespace SimpleCalculator
{
    public class InputConverter 
    {
        public static int ConvertInputToNumeric(string argTextInput)
        {
            //testing push
            int converted = Convert.ToInt32(argTextInput);
            return converted;
        }
    }
}
