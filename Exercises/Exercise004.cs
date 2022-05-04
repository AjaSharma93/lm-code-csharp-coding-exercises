using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            dateTime = dateTime.AddSeconds(1E9);
            // Replace the exception statement below with your code!
            return dateTime;
        }
    }
}
