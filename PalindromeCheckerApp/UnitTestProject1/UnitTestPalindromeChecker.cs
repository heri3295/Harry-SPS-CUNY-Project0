using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeCheckerApp; 

namespace UnitTestPalindromeCheckers
{
    [TestClass]
    public static class UnitTestPalindromeChecker
    {
        [TestMethod]
        public static void palindromeCheckerTesterOne()
        {
            string wordToTest = "A nut for a jar of tuna";
            Console.WriteLine("Checking for " + wordToTest + ". ");
            bool isPalindrome = PalindromeChecker.palindromeChecker(wordToTest, wordToTest);
            Console.WriteLine("Is Palindrome?: " + isPalindrome);
        }

        [TestMethod]
        public static void palindromeCheckerTesterTwo()
        {
            string wordToTest = "Borrow or rob";
            Console.WriteLine("Checking for " + wordToTest + ". ");
            bool isPalindrome = PalindromeChecker.palindromeChecker(wordToTest, wordToTest);
            Console.WriteLine("Is Palindrome?: " + isPalindrome);
        }
        [TestMethod]
        public static void palindromeCheckerTesterThree()
        {
            string wordToTest = "343";
            Console.WriteLine("Checking for " + wordToTest + ". ");
            bool isPalindrome = PalindromeChecker.palindromeChecker(wordToTest, wordToTest);
            Console.WriteLine("Is Palindrome?: " + isPalindrome);
        }
    }
}
