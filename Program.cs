using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a C# program to find the sum of all elements in an integer array using a loop
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            int i = 0;
            for ( i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("the sum of the array is: " + sum);
            //2.Create a C# program that calculates the average of values in a floating-point array using a loop.
            double[] ab = { 1.3, 2.3, 3.4, 4.5, 5.6 };
            double sum1 = 0;
            int j = 0;
            for (j = 0; j < ab.Length; j++)
            {
                sum1 += ab[j];
            }
            double avg = sum / ab.Length;
            Console.WriteLine("the average is: " + sum1);

            // 3.Develop a C# program that finds the largest element in an integer array using a loop and if-else statements.
            int[] ar = { 4, 5, 6, 7, 23, 54 };
            int max = ar[0];
            int k = 0;
            for ( k = 1; k < ar.Length; k++)
            {

                if (max < ar[k])
                {
                    max = ar[k];
                }



            }
            Console.WriteLine("The largest number is: " + max);

            //4.  Write a C# program that counts the number of even and odd elements in an integer array using a loop and if-else statements.

            int[] ar2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int even = 0;
            int odd = 0;
            int s = 0;
            for ( s = 0; s < ar2.Length; s++)
            {
                if (ar2[s] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("the number if even is: " + even);
            Console.WriteLine("the number if odd is: " + odd);
            
             //5. Implement a C# program that reverses the elements of an integer array using a loop.

             int[] ar3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int t = 0;
            int u = ar3.Length - 1;
            while (i < j)
            {
                int temp = ar3[t];
                ar3[t] = ar3[u];
                ar3[u] = temp;
                t++;
                u--;
            }
            for (int l = 0; l < ar3.Length; l++)
            {
                Console.WriteLine(ar3[l]);
            }

        }
    }
}