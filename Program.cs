using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static public class toTest
    {
        static private void qSort(ref int[] arr, int startIndex, int endIndex)
        {
            int l = startIndex, r = endIndex;
            int piv = arr[(l + r) / 2];
            while (l <= r)
            {
                while (arr[l] < piv)
                {
                    l++;
                }
                while (arr[r] > piv)
                {
                    r--;
                }
                if (l <= r)
                {
                    (arr[l], arr[r]) = (arr[r], arr[l]);
                    l++;
                    r--;
                }
            }
            if (startIndex < r)
            {
                qSort(ref arr, startIndex, r);
            }
            if (l < endIndex)
            {
                qSort(ref arr, l, endIndex);
            }
        }
        //1.1
        static public void Sort(ref int[] arr)
        {
            qSort(ref arr, 0, arr.Length - 1);
        }

        //1.2
        static public bool isPalindrome(string str)
        {
            for (int startIndex = 0, endIndex = str.Length - 1; startIndex < endIndex; startIndex++, endIndex--)
            {
                if (str[startIndex] != str[endIndex])
                {
                    return false;
                }
            }
            return true;

        }

        //1.3
        static public int Factorial(int x)
        {
            int a = 1;
            for (int i = x; i > 0; i--)
            {
                a *= i;
            }
            return a;
        }

        //1.4
        static public int Fibonachi(int indexFibonacci)
        {
            indexFibonacci--;
            if (indexFibonacci < 0)
            {
                return -1;
            }
            int[] arrFibonacci = new int[indexFibonacci + 2];
            arrFibonacci[0] = 0;
            arrFibonacci[1] = 1;
            for (int i = 2; i < arrFibonacci.Length; i++)
            {
                arrFibonacci[i] = arrFibonacci[i - 1] + arrFibonacci[i - 2];
            }
            return arrFibonacci[indexFibonacci];
        }

        //1.5
        static public int searchSubstringsInString(string str, string subStr)
        {
            int IndexSubStr = 0;
            for (int indexStr = 0; indexStr < str.Length; indexStr++)
            {
                if (subStr[IndexSubStr] == str[indexStr])
                {
                    IndexSubStr++;
                    if (IndexSubStr == subStr.Length)
                    {
                        return indexStr - IndexSubStr + 1;
                    }
                }
                else
                {
                    IndexSubStr = 0;
                }
            }
            return -1;
        }

        //1.6
        static public bool isPrimeNumber(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //1.7
        static public int Reverse(int num)
        {
            int reversed_num = 0;
            while (num != 0)
            {
                int digit = num % 10;
                if (reversed_num > Int32.MaxValue / 10 || (reversed_num == Int32.MaxValue / 10 && digit > 7))
                {
                    return 0;
                }
                if (reversed_num < Int32.MinValue / 10 || (reversed_num == Int32.MinValue / 10 && digit < -8))
                {
                    return 0;
                }
                reversed_num = reversed_num * 10 + digit;
                num /= 10;
            }
            return reversed_num;
        }

        //1.8
        static public string toRoman(int number)
        {
            if (number < 0 || number > 3999)
            {
                return "error";
            }


            if (number == 0)
            {
                return "Null";
            }

            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] dict = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(dict[i]);
                }
            }

            return result.ToString();
        }
    }

    public class program
    {
        public static void Main()
        {
        }
    }
}
