using System;

namespace MissingNumber
{
    public class Class1
    {
        public static void Main()
        {
            Console.WriteLine("Herhangi bir sayı yaz");
            string maksNumber = Console.ReadLine();
            
            int N = Convert.ToInt32(maksNumber);

            int total_sum = 0;
            int num;
            Console.WriteLine(N + "'den daha küçük sayılar gir");
            for (int i = 0; i < N-1; i++)
            {
                Console.Write("Sayı gir: ");
                string currentNum = Console.ReadLine();
                num = Convert.ToInt32(currentNum);
                total_sum += num;
                
            }

            int expected_sum = (N * (N + 1)) / 2;
            int missingNumber = expected_sum - total_sum;
            Console.WriteLine(missingNumber);
        }
    }
}