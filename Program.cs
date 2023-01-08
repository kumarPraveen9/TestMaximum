namespace TestMaximum
{
    class Program
    {
        public static void Main(String[] args)
        {
            
            testCases<float> test = new testCases<float>();
            Console.WriteLine("Given Max Number at 1st Position from {5.5, 4.4, 3.73}return the Same Number:Test Case(1) ");
           Console.WriteLine( test.maxi(5.5F, 4.4F, 3.73F));
            Console.WriteLine("Given Max Number at 2nd Position from {55.8, 89.76, 73.66} return the Same Number:Test Case(2) ");
            Console.WriteLine(test.maxi(55.8F, 89.76F, 73.66F));
            Console.WriteLine("Given Max Number at 3rd Position from {101.56, 447.01, 833.09} return the Same Number:Test Case(3) ");
            Console.WriteLine(test.maxi(101.56F, 447.01F, 833.09F));

           

        }
    }
}
