using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sum = new List<int>();
            if (numbers == null)
            {
                return false;
            }

            var answer = numbers.Sum();
            if (answer % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var result = new List<bool>();

            foreach (var item in password)
            {
                if (char.IsNumber(item))
                {
                    result.Add(true);
                    break;
                }
            }
            foreach (var item2 in password)
            {
                if (char.IsLetter(item2) && char.IsLower(item2))
                {
                    result.Add(true);
                    break;
                }
            }
            foreach (var item3 in password)
            {
                if (char.IsLetter(item3) && char.IsUpper(item3))
                {
                    result.Add(true);
                    break;
                }
            }
            if (result.Count == 3)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.Substring(0).First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0m;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            int result1 = nums.Last();
            int result2 = nums.First();

            return result1 - result2;
        }

        public int[] GetOddsBelow100()
        {
            int[] Finalresult = new int[] { };
            var result = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            words[i] = words[i].ToUpper();
        }
    }
}
