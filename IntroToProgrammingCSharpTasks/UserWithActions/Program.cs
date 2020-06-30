using System;

namespace UserWithActions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter city:");
            string city = Console.ReadLine();

            User user = new User(email, firstName, lastName, age, city);

            Console.WriteLine("Select option:");
            Console.WriteLine("1) Introduce user");
            Console.WriteLine("2) Is user adult or not");
            Console.WriteLine("3) Where is user from");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    user.IntroduceMyself();
                    break;
                case 2:
                    user.AmIAdult();
                    break;
                case 3:
                    user.WhereAmIFrom();
                    break;
                default:
                    Console.WriteLine("Incorect option picked!");
                    break;
            }
        }
    }
}
