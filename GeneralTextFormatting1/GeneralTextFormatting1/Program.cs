using System;
using static System.Console;

namespace GeneralTextFormatting1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                WriteLine("\n------");
                WriteLine("Task 1");
                WriteLine("------\n");
                WriteLine("Hi, there! I am Mahesh.");
            }
            {

                WriteLine("\n------");
                WriteLine("Task 2");
                WriteLine("------\n");
                int var1 = 5;           //define variable of INTEGER
                WriteLine("Value of var1 is {0}", var1);
            }
            {
                WriteLine("\n------");
                WriteLine("Task 3");
                WriteLine("------\n");
                Write("Text1");         //write method allow merge text
                Write("Text2");
                Write("Text1");
                WriteLine("\nfirst line");      // \n is escape char for new line
                WriteLine("this line will not merge due to writeline()");
            }
            {
                WriteLine("\n------");
                WriteLine("Task 4");
                WriteLine("------\n");
                WriteLine("two sample integer are {0} and {1} and min is {0}", 25, 50);

            }
            {
                WriteLine("\n------");
                WriteLine("Task 5");
                WriteLine("------\n");

                int latitude = 43;
                int longitude = 11;
                string north = "N";
                string south = "S";
                string east = "E";
                WriteLine($"The city of Florence, Italy is located" +
                    $" at latitude {latitude}{north} and longitude {longitude}{east}." +
                    $" By comparison, the city of Djibouti(in the country of Djibouti) is located" +
                    $" at latitude {longitude}{north} and longitude {latitude}{east}." +
                    $" The city of Moroni in the Comoros Islands is located" +
                    $" at latitude { longitude}{south} and longitude {latitude}{east}.");


            }
            {
                WriteLine("\n------");
                WriteLine("Task 6");
                WriteLine("------\n");
                WriteLine("The value: {0}", 500);
                WriteLine("The value in currency format: {0:c}", 500);
            }
            {
                WriteLine("\n------");
                WriteLine("Task 7");
                WriteLine("------\n");
                WriteLine("The alignment specifier: |{0, 10}|", 500);
                WriteLine("The alignment specifier: |{0, -10}|", 500);
            }
            {
                WriteLine("\n------");
                WriteLine("Task 8: Format field");
                WriteLine("------\n");
                double myDouble = 12.345678;
                WriteLine("{0,-10:G} -- General", myDouble);
                WriteLine("{0,-10} -- Default, same as General", myDouble);
                WriteLine("{0,-10:F4} -- Fixed Point, 4 dec places", myDouble);
                WriteLine("{0,-10:C} -- Currency", myDouble);
                WriteLine("{0,-10:E3} -- Sci. Notation, 3 dec places", myDouble);
                WriteLine("{0,-10:x} -- Hexadecimal integer", 1194719);

            }
            {
                // format field with string interpolation
                WriteLine("\n------");
                WriteLine("Task 9: Format field");
                WriteLine("------\n");

                double myDouble = 12.345678;

                WriteLine($"{myDouble,-10:N2} -- Number");
                WriteLine($"{myDouble,-10:p4} -- percentage 4 dig after '.'");
                WriteLine($"{myDouble,-10:F4} -- Fixed Point, 4 dec places");
                WriteLine($"{myDouble,-10:C} -- Currency");                     //that dont't print currency (prints ??)
                WriteLine($"{myDouble,-10:E3} -- Sci. Notation, 3 dec places");
                WriteLine($"{1194719,-10:x} -- Hexadecimal integer");
                /*
                  this is multiline comment
                  this program contains general text formating...
                 
                 */
            }
        }
    }
}
