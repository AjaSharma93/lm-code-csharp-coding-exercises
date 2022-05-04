using Exercises.Models;
using System;
namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            // Replace the exception statement below with your code!
            return person.City == "Manchester";
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            // Replace the exception statement below with your code!
            return person.Age > ageLimit;
        }
    }
}
