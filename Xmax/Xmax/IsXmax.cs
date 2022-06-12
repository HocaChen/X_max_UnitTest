using System;

namespace Xmax
{
    public class IsXmax
    {
        static void Main()
        {
            var logic = new Logic();
            Console.WriteLine(logic.TodayIsXmax()); 
        }
    }

    public class Logic
    {
        public string TodayIsXmax()
        {
            var today = GetDate();
            if (today.Month == 12 && today.Day == 25)
                return "Today is Xmax";
            else
                return "Today is not Xmax";

        }

        protected virtual DateTime GetDate()
        {
            return DateTime.Today;
        }
    }
}
