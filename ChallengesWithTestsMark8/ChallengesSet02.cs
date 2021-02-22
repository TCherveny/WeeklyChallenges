using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //(2) ways to do it with Linq:
            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();

            //if (numbers == null || numbers.Count() == 0)
            //{
            //    return 0;
            //}
            //return numbers.Min() + numbers.Max();

            //regular C# way:





        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.length < str2.length ? str1.length : str2.length;
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            var sum = 0;
            for (int i =0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }
        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= object)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
