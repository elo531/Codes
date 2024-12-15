using System;
using System.Dynamic;

namespace GreeterProgram
{
    public class Greeter
    {
        // Fields to store name and age
        public string name;
        public int age;

        // Method to ask for the user's name
        public void AskName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        // Method to ask for the user's age
        public void AskAge()
        {
            Console.WriteLine("What is your age?");
            // Ensure valid input for age
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input. Please enter a valid age:");
            }
        }
        public class Customer{
            public name, age;
            public createCustomer(){
                    System.WriteLine("What is you name?");
                    name = System.ReadLine();
                    
            }
            public Customer(){
              System.WriteLine($"Customer 1: {name}")
            }
            public setAge(str){
                int age = int.Parse(str);
                   System.WriteLine($"Your age is : {age}");
            }
        }
        public class NotificationService{

        }

        // Main method (entry point)
        public static void Main(string[] args)
        {
            // Create an instance of Greeter
            Greeter greeter = new Greeter();

            // Ask the user for their name and age
            greeter.AskName();
            greeter.AskAge();

            // Display the greeting message
            Console.WriteLine($"Hello, {greeter.name}!");
            Console.WriteLine($"You are {greeter.age} years old.");
            //
            Customer cust = new Customer();
            cust.createCustomer();
            cust.Customer();
            cust.setAge(89);
            cust.NotificationService();
        }
    }
}
