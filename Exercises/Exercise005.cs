using System;
using System.Linq;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            string loweredInput = input.ToLower();
            string englishLetters = "abcdefghijklmnopqrstuvwxyz";
            return englishLetters.All((alphabet)=>loweredInput.Contains(alphabet));
        }
    }
}
