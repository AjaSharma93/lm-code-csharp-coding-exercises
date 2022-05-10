using System;
using System.Linq;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            return (string.IsNullOrEmpty(word))?word:(char.ToUpper(word[0]) + word.Substring(1));
        }

        public string GenerateInitials(string firstName, string lastName)
        {
            string result = "";
            if(!string.IsNullOrEmpty(firstName)) result = result + firstName[0];
            if(!string.IsNullOrEmpty(lastName)) result = result + "." + lastName[0];
            return result;
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            return Math.Round((1 + vatRate/100) * originalPrice,2);
        }

        public string Reverse(string sentence)
        {
            char[] chars = sentence.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public int CountLinuxUsers(List<User> users)
        {
            return users.Aggregate(0,(acc, user) => (user.Type == "Linux")?(acc+1):acc);
        }
    }
}
