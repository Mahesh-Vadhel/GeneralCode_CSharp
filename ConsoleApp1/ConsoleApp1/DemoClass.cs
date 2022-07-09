using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DemoClass
    {
        static List<int> My_variale = new List<int>()
        {
            1,2,3, 4, 5, 6, 7
        };

        public static string getAllElement()
        {
            string abc = String.Join(",", My_variale);

            return abc;
        }
    
    }
}