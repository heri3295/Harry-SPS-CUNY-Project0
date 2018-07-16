using System;
using PalindromeCheckerApp;
using UnitTestPalindromeCheckers; 

namespace PalindromeCheckerApp
{
    class PalindromeCheckerMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling the testing methods for the PalindromeChecker method.");
            Console.WriteLine("Thus far this program cannot handle palindromes with spaces in them.");
            UnitTestPalindromeChecker.palindromeCheckerTesterOne();
            UnitTestPalindromeChecker.palindromeCheckerTesterTwo();
            UnitTestPalindromeChecker.palindromeCheckerTesterThree();

            Console.Read();
            
        }
    }
}
