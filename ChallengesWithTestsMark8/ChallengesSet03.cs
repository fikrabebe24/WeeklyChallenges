using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(bool item in vals)
            {
                if(item == false)
                {
                    return true;
                }
                
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sumOfNums = numbers.Sum();

            if(sumOfNums % 2 > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           if(password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];


        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {

            var oddsBelowHund = new List<int>();

            for(int n = 0; n <= 100; n++)
            {
                if(n < 100 && n % 2 != 0)
                {
                    oddsBelowHund.Add(n);
                }
            }
            return oddsBelowHund.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int e = 0; e < words.Length; e++)
            {
                words[e] = words[e].ToUpper();
            }

        }
    }
}
