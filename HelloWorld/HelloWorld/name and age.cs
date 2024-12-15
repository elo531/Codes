using System;

namespace HelloWorld
{
    public class NameAndAge
    {
        // Fields to store name and age
        public string name;
        public int age;

        // Method to ask for and return the name
        public void AskName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        // Method to ask for and return the age
        public void AskAge()
        {
            Console.WriteLine("What is your age?");
            // Convert the input string to an integer
            age = int.Parse(Console.ReadLine());
        }

        // Main method

    }
}
