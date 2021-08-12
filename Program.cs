using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rs = User.PasswordR4();
            Console.WriteLine(rs);
        }
    }
}