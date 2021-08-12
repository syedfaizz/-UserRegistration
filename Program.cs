using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rs = User.ValidateLastName();
            Console.WriteLine(rs);
        }    
    }
}
