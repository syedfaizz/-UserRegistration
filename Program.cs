using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rs = User.ValidateFirstName();
            Console.WriteLine(rs);
        }    
    }
}
