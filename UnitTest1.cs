using ConsoleApp1;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //1.1
        [TestCase(new int[] { 1, 0, 3, 4 }, new int[] { 0, 1, 3, 4 })]
        [TestCase(new int[] { 5, 2, 7, 1, 3 }, new int[] { 1, 2, 3, 5, 7 })]
        [TestCase(new int[] { 9, 8, 7, 6, 5 }, new int[] { 5, 6, 7, 8, 9 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4 })]
        public void Sort(ref int[] n, int[] res)
        {
            toTest.Sort(ref n);
            Assert.AreEqual(res, n);
        }




        //1.2
        [TestCase("1111", true)]
        [TestCase("radar", true)]
        [TestCase("level", true)]
        [TestCase("hello", false)]
        [TestCase("amanaplanacanalpanama", true)]
        public void Palindrom(string n, bool res)
        {
            Assert.AreEqual(res, toTest.isPalindrome(n));
        }


        //1.3
        [TestCase(3, 6)]
        [TestCase(0, 1)]
        [TestCase(5, 120)]
        [TestCase(7, 5040)]
        [TestCase(10, 3628800)]
        public void Factorial(int n, int res)
        {
            Assert.AreEqual(res, toTest.Factorial(n));
        }


        //1.4
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(5, 3)]
        [TestCase(8, 13)]
        [TestCase(10, 34)]
        public void Fibonachi(int n, int res)
        {
            Assert.AreEqual(res, toTest.Fibonachi(n));
        }


        //1.5
        [TestCase("abcdefg", "a", 0)]
        [TestCase("abcdefg", "b", 1)]
        [TestCase("abcdefg", "g", 6)]
        [TestCase("abcdefg", "q", -1)]
        public void searchSubstringsInString(string s, string sub, int res)
        {
            Assert.AreEqual(res, toTest.searchSubstringsInString(s, sub));
        }

        //1.6
        [TestCase(1, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(64, false)]
        public void isPrimeNumber(int n, bool res)
        {
            Assert.AreEqual(res, toTest.isPrimeNumber(n));
        }

        //1.7
        [TestCase(-12, -21)]
        [TestCase(2147483647, 0)]
        [TestCase(-10, -1)]
        [TestCase(200, 2)]
        public void Reverse(int n, int res)
        {
            Assert.AreEqual(res, toTest.Reverse(n));
        }

        //1.8
        [TestCase(1, "I")]
        [TestCase(0, "Null")]
        [TestCase(-10, "error")]
        [TestCase(100, "C")]
        [TestCase(1010, "MX")]
        [TestCase(3, "III")]
        public void toRoman(int n, string res)
        {
            Assert.AreEqual(res, toTest.toRoman(n));
        }

    }
}