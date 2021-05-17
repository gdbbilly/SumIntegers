using System;
using System.Collections.Generic;
using System.Linq;

namespace SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Line of input");
                string result = Calculate.Process(Console.ReadLine());

                Console.Write(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex}");
            }
            finally
            {
                Console.ReadLine();
            }
		}





		

	}
}
