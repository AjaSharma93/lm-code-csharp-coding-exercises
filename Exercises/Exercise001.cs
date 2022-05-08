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
            if(string.IsNullOrEmpty(word)) return "";
            // Replace the exception statement below with your code!
            string result = "";
            if(word != null && word!="")
            {
                result = word[0].ToString().ToUpper()+word.Substring(1);
            }
            return result;
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
            // Replace the exception statement below with your code!
            return Math.Round((1 + vatRate/100) * originalPrice,2);
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            char[] chars = sentence.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            return users.Aggregate(0,(acc, user) => (user.Type == "Linux")?(acc+1):acc);
        }
    }
}
