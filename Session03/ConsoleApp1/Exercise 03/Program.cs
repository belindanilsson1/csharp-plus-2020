using System;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            double[] numberArray = new double[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                try
                {
                    numberArray[i] = Convert.ToDouble(inputArray[i]);
                }
                catch (Exception)
                {
                    numberArray[i] = 0;
                }

                foreach (var number in numberArray)
                {
                    Console.WriteLine("Värde: " + number.ToString());
                }
            }
          
            
        }
    }
}
