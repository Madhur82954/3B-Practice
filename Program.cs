using System;

namespace _3B_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Constructors honda = new Constructors();
            Console.WriteLine(honda.model);
            Constructors yamaha = new Constructors("yamaha");
            Console.WriteLine(yamaha.model);

            IPhone phone = new Interface();
            phone.GetPhoneDetails();

            AccessModifiers access = new AccessModifiers();
            Console.WriteLine(access.Age);
            Console.WriteLine(access.Address);
        }
    }
}
