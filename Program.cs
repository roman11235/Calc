using System;
using System.Data;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Please enter the correct math expression in one line and press Enter.");
                Console.WriteLine("=" + Convert.ToDecimal(new DataTable().Compute(Console.ReadLine(), null)));
            }
            catch
            {
                Console.WriteLine("Incorrect math expression");
            }

            Console.WriteLine("press Enter to Exit");
            Console.ReadLine();
        }
    }
}
