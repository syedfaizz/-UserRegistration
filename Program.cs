using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rs = User.PasswordR1();
            Console.WriteLine(rs);
        }
    }
}