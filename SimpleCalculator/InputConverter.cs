using System;

namespace SimpleCalculator
{
    public class InputConverter 
    {
        public static int ConvertInputToNumeric(string argTextInput)
        {
            //testing push
            //testing push again
            int converted = Convert.ToInt32(argTextInput);
            return converted;
        }
    }
}
