using System;
using static System.Console;

namespace abc
{
   class Program
    {
        string name = "\amahesh\vvadhel\"";
        public float mCalc(float f1, float f2)
        {
            return f1 + f2;
        }

        public void getDatetime()
        {
            DateTime dt = DateTime.UtcNow;
            DateTime New_time = dt.AddHours(5).AddMinutes(30);
            int hour = New_time.Hour;
            int minute = New_time.Minute;
            int newSecond = New_time.Second;
            int Newhour = hour - 12;
            if (hour > 12)
            {
                Newhour.GetHashCode();
                
              Console.WriteLine($"time Now: {Newhour}:0{minute}:{newSecond} PM");
                
            }
            else
                Console.WriteLine($"time Now: 0{Newhour}:0{minute}:{newSecond} AM");
            
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            //            p1.getDatetime();
            Console.WriteLine(p1.name);
            int x = 10, y = 9;
            Console.WriteLine("X is{0} greater than y",
                x > y
                ? ""
                : "not");
        }


    }
}