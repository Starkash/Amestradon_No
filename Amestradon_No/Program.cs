using System;

namespace Amestradon_No
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Number");
            int n1 = int.Parse(Console.ReadLine());
            int result = 0; int m = n1;
            while (n1 != 0)
            {
                int rem = n1 % 10;
                int cube = rem * rem * rem;
                //result = result + cube;
                n1 /= 10;
                result = result + cube;
            }
            if(m==result)
            
            Console.WriteLine("This is a Amestradon Number ");
            else
            {
                Console.WriteLine("This is not Amestradon Number");
            }

        }
    }
}
