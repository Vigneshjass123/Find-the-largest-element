using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 222, 3, 5, 7, 80, 9, 10,11 };
            int temp = 0;


            for (int i = 0; i < ar.Length; i++)
            
               // for (int J = i + 1; J < ar.Length; i++)
                
                    if (ar[i] > temp)
                    {
                        temp = ar[i];
                    }
                    Console.WriteLine("Largest element is = " + temp);
                }
            }

        }
    


    


