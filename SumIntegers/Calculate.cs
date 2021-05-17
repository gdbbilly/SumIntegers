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
			int n = Convert.ToInt32(inputArr.FirstOrDefault());
			n = (n * (n - 1) / 2);

			List<int> numbersInput = inputArr.Skip(1).Select(x=>Convert.ToInt32(x)).ToList();

            string result = CalculatePairsumonious(numbersInput, n);
			if (string.IsNullOrEmpty(result))
				result = "Impossible";

			return result;
		}

		
		private static string CalculatePairsumonious(List<int> numbersInput, int n)
		{
			numbersInput.Sort();

			string result = "";
			for (int i = 2; i < (n); i++)
			{
				int numberTemp = numbersInput[0] + numbersInput[1] - numbersInput[i];
				if (numberTemp % 2 == 1) 
					continue;

				var answer = MountNumbers(numberTemp / 2, numbersInput);

				result = string.Join(" ", answer.ToArray());
			}

			return result;
		}

		private static List<int> MountNumbers(int numberCalc, List<int> numbersInput)
		{
			List<int> ret = new List<int>() { numberCalc };

            for (int i = 0; i < numbersInput.Count - 1; i++)
            {
				int next = numbersInput[i] - ret.FirstOrDefault();
				ret.Add(next);
			}


			return ret;
		}

	}
}
