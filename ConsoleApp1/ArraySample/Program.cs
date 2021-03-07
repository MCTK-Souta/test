using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array=new int[4];
            //array[0] = 32;
            //array[1] = 31;
            //array[2] = 30;
            //array[3] = 0;

            //int[] array = new int[]
            //{
            //    32,31,30,0
            //};
            
            //for(int i=0;i<array.Length; i++)
            //{
            //    Console.WriteLine("  " + array[i]);
            //}

            foreach(string item in args)
            {
                Console.WriteLine("  " + args);
            }

            Console.Read();
        }

        static void Process(int[] arr)
        {
            //if (arr != null)
            //    throw new ArgumentException();

            //for(int i=0;i<arr.Length;i++)
            //{
            //    Console.WriteLine("  " + arr[i]);
            //}
        }

    }
}
