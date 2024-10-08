using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is how comments are written
            
            /* This is how
             multiline
             comments work */
            
            Console.WriteLine("Hello World!");
            Console.WriteLine(3 + 3);

            string name = "Gary";
            Console.WriteLine(name);

            int myNum = 777;
            Console.WriteLine(myNum);

            int myNewNum;
            myNewNum = 5;
            Console.WriteLine(myNewNum);
            
            char letter = 'A';
            bool myBool = true;
            
            const int myConstant = 42;
            // myConstant = 50; This would cause an error
            
            Console.WriteLine("Hello " + name);

            string firstName = "Gary";
            string lastName = "Stone";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
            
            int x = 5;
            int y = 10;
            Console.WriteLine(x + y); // This will output 5 + 10, which equals 15

            int a = 1, b = 2, c = 3;
            Console.WriteLine(a+b+c);

            int d, e, f;
            d = e = f = 4;
            Console.WriteLine(d+e+f);
            
            double myDouble = 5.99D; // This is how decimals are stored
            Console.WriteLine(myDouble);
        }
    }
}

