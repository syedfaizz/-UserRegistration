using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rs = User.ValidateEmail();
            Console.WriteLine(rs);
        }    
    }
}
