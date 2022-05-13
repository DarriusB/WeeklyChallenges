using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            char.IsLetter(c);
            return true;
        }

        public bool CharacterIsNotALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            } 
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            foreach (var num in numbers)
            {
                double min = numbers.Min();
                double max = numbers.Max();
                double result = min + max;
                return result;
            }
            return 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Count();
            }
            else
            {
                return str2.Count();
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int result = numbers.Sum();
            return result;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var answer = new List<int>();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    answer.Add(num);
                }
            }
            var result = answer.Sum();
            return result;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var answer = new List<int>();
            foreach (var num in numbers)
            {
                answer.Add(num);
            }
            var result = answer.Sum();
            if (result % 2 != 0)
            {
                return true;
            }
            else if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var answer = new List<int>();

            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0 && i >= 0)
                {
                    answer.Add(i);
                }
            }
            long result = answer.Count();
            return result;
        }
    }
}
