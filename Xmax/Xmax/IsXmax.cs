using System;

namespace Xmax
{
    public class IsXmax
    {
        static void Main()
        {
            var today = DateTime.Today;
            if(today.Month == 12 && today.Day == 25)
                Console.WriteLine("Today is Xmax");
            else
                Console.WriteLine("Today is not Xmax");
        }
    }
}
