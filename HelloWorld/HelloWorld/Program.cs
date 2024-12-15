using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            checked
            { 
                byte number = 255;
                Console.WriteLine(number);
            }
             NameAndAge nag = new NameAndAge();

            // Call methods to get name and age
            nag.AskName();
            nag.AskAge();
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);
        }
    }
    
}

