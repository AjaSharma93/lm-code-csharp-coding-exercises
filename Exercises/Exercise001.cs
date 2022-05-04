using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
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
            if(firstName != null && firstName.Length > 0) result = result + firstName[0];
            if(lastName != null && lastName.Length > 0) result = result + "." + lastName[0];
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
            int countUsers = 0;
            users.ForEach(user =>
            {
                if (user.Type == "Linux")
                    countUsers++;
            });
            return countUsers;
        }
    }
}
