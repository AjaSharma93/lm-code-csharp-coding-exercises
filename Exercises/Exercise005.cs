using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            bool result = true;
            string loweredInput = input.ToLower();
            string englishLetters = "abcdefghijklmnopqrstuvwxyz";
            for(int i = 0; i < englishLetters.Length; i++)
            {
                result = result && loweredInput.Contains(englishLetters[i]);
            }
            return result;
        }
    }
}
