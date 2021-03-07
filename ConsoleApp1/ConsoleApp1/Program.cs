using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("App 6");

            int result = Mathcore.Add(5, 6);
            Console.WriteLine("5 + 6 =" + result);

            Console.ReadLine();

#if DEBUG
            Console.WriteLine(1);
#endif


#if RELEASE
            Console.WriteLine(2);
#endif
        }



        static void GOGOGO()
        {
            int result = Mathcore.Add(5, 6);
        }


        /*
        int a = 90;
        int b = 80;
        int c = a + b;
        Console.WriteLine(c.ToString("0000"));
        Console.ForegroundColor = ConsoleColor.Green;
        string AAA = "HIHI";
        Console.WriteLine(c + AAA);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{a}+ {b} = {c}");

        string inputText = Console.ReadLine();
        Console.WriteLine(inputText);
        Console.Read();


        Console.WriteLine("Plese input an Integer:A.");
        string inpTextA = Console.ReadLine();
        Console.WriteLine("Plese input an Integer:B.");
        string inpTextB = Console.ReadLine();

        int inpA = Convert.ToInt32(inpTextA);
        int inpB = Convert.ToInt32(inpTextB);

        Console.Write("A+B=");
        Console.WriteLine(inpA + inpB);
        Console.ReadLine();

        try
        {
            int a = 1;
            int b = 0;
            Console.WriteLine(a / b);

        }
        catch(Exception ex)
        {
            Console.WriteLine("some error happen");
        }
        finally
        {

        }
        

        WriteInfo();
            WriteInfo();

            try
            {
                Console.WriteLine(Add(1, 3)/0);
                Console.WriteLine(Add(5, 7));
            }

            catch
            {
                Console.WriteLine("錯誤");
            }

            Console.Read();

        
        }

        static void WriteInfo()
        {
            Console.WriteLine("hi");

        }

        static int Add(int a,int b)
        {
            return a + b;
        }
        */


    }
}
