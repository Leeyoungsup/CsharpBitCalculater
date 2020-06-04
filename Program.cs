using System;

namespace BitCalculater
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = 1;
            // << >> &(and) |(or) ^(xor) ~(not)
            num = num << 3;//0001-> 1000
            num = num >> 1;//1000 -> 0100
            uint num1 = 15;//1111
            uint num2 = 6;//0110
            num = num1 & num2;//0110
            num = num1 | num2;//1111
            num = num1 ^ num2;//1001
            num = ~num1;//1111111111110000
            Console.WriteLine(num);
            
        }
    }
}
