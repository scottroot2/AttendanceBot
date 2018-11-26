using System;
using System.Globalization;

namespace AttendanceBot.Helpers
{
    public class Conversions
    {
        public static int ConvertToNumber(string value)
        {
            if (value == string.Empty) return 0;

            try
            {
                var dec = decimal.Parse(value,
                    NumberStyles.AllowDecimalPoint |
                    NumberStyles.Number |
                    NumberStyles.AllowThousands);

                return (int)Math.Round(dec);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Please input a number.");
                return 0;
            }
        }
    }    
}