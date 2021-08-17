using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rs = User.PasswordR2();
            Console.WriteLine(rs);
        }
    }
}