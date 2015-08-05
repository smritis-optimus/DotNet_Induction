using System;

namespace SampleWebApp
{
    public class Student
    {
        public float GetPercentage(string percentage)
        {
                float valueOfTextBox;
                if (float.TryParse(percentage, out valueOfTextBox))
                {
                    if (valueOfTextBox >= 0 && valueOfTextBox <= 100)
                        return valueOfTextBox;
                    else
                        return 0;//return 0 if percentage out of range
                }
                else
                    throw new FormatException("Input string was not in a correct format.");//throw an exception when user enters incorrect format
        }
    }
}