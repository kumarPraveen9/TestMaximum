using System.IO;
using System;

namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {

           
            
            
            maxy<int> test1 = new maxy<int>();
            Console.WriteLine("Given Max Number at 1st Position from {5,4,3}return the Same Number:Test Case(1) ");
            test1.maxmathod(5, 4, 3);
            Console.WriteLine("Given Max Number at 2nd Position from {55,88,73} return the Same Number:Test Case(2) ");
            test1.maxmathod(55, 89, 73);
            Console.WriteLine("Given Max Number at 3rd Position from {101,447,833} return the Same Number:Test Case(3) ");
            test1.maxmathod(101, 447, 833);

            Console.WriteLine("---------------------------------------------------------------------------");


            maxy<float> test2 = new maxy<float>();
            Console.WriteLine("Given Max Number at 1st Position from {5.5, 4.4, 3.73}return the Same Number:Test Case(1) ");
            test2.maxmathod(5.5F, 4.4F, 3.73F);
            Console.WriteLine("Given Max Number at 2nd Position from {55.8, 89.76, 73.66} return the Same Number:Test Case(2) ");
            test2.maxmathod(55.8F, 89.76F, 73.66F);
            Console.WriteLine("Given Max Number at 3rd Position from {101.56, 447.01, 833.09} return the Same Number:Test Case(3) ");
            test2.maxmathod(101.56F, 447.01F, 833.09F);

            Console.WriteLine("---------------------------------------------------------------------------");
            maxy<string> test = new maxy<string>();
            
            Console.WriteLine("Given Max Number at 1st Position from {Peach\",\"Apple\", \"Banana}return the Same Number:Test Case(1) ");
            test.maxmathod("Peach", "Apple", "Banana");

            Console.WriteLine("Given Max Number at 2nd Position from {icon\", \"volume\", \"shape} return the Same Number:Test Case(2) ");
            test.maxmathod("icon", "volume", "shape");

            Console.WriteLine("Given Max Number at 3rd Position from {\"docter\", \"lawyer\", \"sofware.E\"} return the Same Number:Test Case(3) ");
            test.maxmathod("docter", "lawyer", "sofware.E");


        }
    }
}
