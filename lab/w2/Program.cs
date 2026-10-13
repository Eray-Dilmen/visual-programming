using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w2
{
 
    internal class Program
    {
        static void BitwiseOperations()
        {
            int A = 60;
            int B = 13;


            // A&B bitwise AND. Not &&. Returns 1 only if both bits are 1.
            Console.WriteLine("\nA&B: " + (A & B)); /* output: 12
            A: 0 0 1 1   1 1 0 0 (60)
            B: 0 0 0 0   1 1 0 1 (13)
            -------------------------
          A&B: 0 0 0 0   1 1 0 0 -> 8 + 4 = 12 */


            // A|B bitwise OR. Not ||. Returns 1 if at least one bit is 1.
            Console.WriteLine("\nA|B: " + (A | B)); /* output: 61
            A: 0 0 1 1   1 1 0 0 (60)
            B: 0 0 0 0   1 1 0 1 (13)
            -------------------------
          A|B: 0 0 1 1   1 1 0 1 -> 32 + 16 + 8 + 4 + 1 = 61 */


            // A^B bitwise XOR. Returns 1 if bits are different, 0 if same.
            Console.WriteLine("\nA^B: " + (A ^ B)); /* output: 49
             A: 0 0 1 1   1 1 0 0 (60)
             B: 0 0 0 0   1 1 0 1 (13)
            -------------------------
           A^B: 0 0 1 1   0 0 0 1 -> 32 + 16 + 1 = 49 */


            Console.WriteLine("~A: " + (~A));
            // A in bit: 00111100 -> 32 + 16 + 8 + 4
            // ~ (NOT) operand makes reverse 1 & 0's 
            // A~ -> 11000011 -> very left part is declaring sign (1 is negative, 0 is positive) (extra note: this is applied on signed types [int, short, sbyte, long]. unsigned types [uint, ushort, ulong, byte].
            // -> -128 + 64 + 2 + 1 -> -128 + 67 -> -61. So output will be -61


            // Left Shift 
            Console.WriteLine("\nA<<2: " + (A << 2)); // output: 240 because in left shift, each shifting multiply by 2 so 2^2 60x4 = 240  

            // Right Shift
            Console.WriteLine("\nA>>2: " + (A >> 2)); // output: 15. in right shift, each shifting divide by 2. 2^2 -> 60/4 = 15.

        }
        

        static void Main(string[] args)
        {

            BitwiseOperations();





            // Enum

            // what happens hwen you define a variable by another variable
            // int a = 10;
            // int b = a;

            // Console.WriteLine(a);


            /*
            Console.WriteLine("Write Your name");
            string names = Console.ReadLine();

            Console.WriteLine(names);

            Console.ReadKey();
            */



            ///  Calculating Area 
            /*
            Console.WriteLine("Enter Width");
            string w = Console.ReadLine();

            Console.WriteLine("Enter Height");
            string h = Console.ReadLine();

            int A = Convert.ToInt32(w) * Convert.ToInt32(h);
            Console.WriteLine("Area: " + A);
            */


            


        }
    }
}
