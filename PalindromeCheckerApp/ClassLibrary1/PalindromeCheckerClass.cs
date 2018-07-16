using System;

namespace PalindromeCheckerApp
{
    public static class PalindromeChecker
    {
        public static bool palindromeChecker(string firstWord, string secondWord)
        {
            for (int indexTwo = (secondWord.Length - 1), indexOne = 0; indexTwo > 0; indexTwo--, indexOne++)
            {
                char letOne = firstWord[indexOne];
                char letTwo = secondWord[indexTwo];
                if (!(letOne.Equals(letTwo))) { return false; }
            }
            return true;
        }

    }
}
