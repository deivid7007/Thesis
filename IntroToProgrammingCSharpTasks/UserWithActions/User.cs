using System;

namespace UserWithActions
{
    public class User
    {
        public User(string email, string firstName, string lastName, int age, string city)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.City = city;
        }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public void IntroduceMyself()
        {
            Console.WriteLine($"I am {FirstName + ' ' + LastName}, {Age} years old and my email is {Email}");
        }

        public void AmIAdult()
        {
            if (Age >= 18)
            {
                Console.WriteLine("Yes I am adult, because I am equal or above age of 18");
            }
            else
            {
                Console.WriteLine("No I am not adult, because I am under age of 18");
            }
        }

        public void WhereAmIFrom()
        {
            Console.WriteLine($"I am from {City}");
        }
    }
}
