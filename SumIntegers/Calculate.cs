using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumIntegers
{
    public static class Calculate
    {
        public static string Process(string userInput)
        {
            var inputArr = userInput.Split(' ');
            
            List<int> numbersInput = inputArr.Skip(1).Select(x => Convert.ToInt32(x)).ToList();

            string result = CalculatePairsumonious(numbersInput);
            if (string.IsNullOrEmpty(result))
                result = "Impossible";

            return result;
        }


        private static string CalculatePairsumonious(List<int> numbersInput)
        {
            numbersInput.Sort();

            if (numbersInput.Count >= 3)
            {
                int numberTemp = numbersInput[0] + numbersInput[1] - numbersInput[2];
                if (numberTemp % 2 == 0)
                {
                    var answer = MountAnswer(numberTemp / 2, numbersInput);

                    return string.Join(" ", answer.ToArray());
                }
            }

            return string.Empty;
        }

        private static List<int> MountAnswer(int numberCalc, List<int> numbersInput)
        {
            List<int> ret = new List<int>() { numberCalc };

            while (numbersInput.Count > 0)
            {
                int next = numbersInput[0] - ret[0];
                for (int i = 0; i < ret.Count; i++)
                {
                    var removeIndex = numbersInput.IndexOf(next + ret[i]);
                    if (removeIndex >= 0)
                    {
                        numbersInput.RemoveAt(removeIndex);
                        numbersInput.TrimExcess();
                    }
                    else
                    {
                        return new List<int>();
                    }
                }
                ret.Add(next);
            }


            return ret;
        }
    }
}
