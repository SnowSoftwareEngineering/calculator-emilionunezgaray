namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Welcome to the calculator project, complete the methods

            // Call the methods here ex.
            int result1 = Add(2, 3);
            Console.WriteLine("The result of adding 2 and 3 is: " + result1);

            int result2 = Subtract(2, 3);
            Console.WriteLine("The result of subtracting 2 and 3 is:" + result2);

            int result3 = Subtract(2, 3);
            Console.WriteLine("The result of multiplying 2 and 3 is:" + result3);

            int result4 = Subtract(2, 3);
            Console.WriteLine("The result of dividing 2 and 3 is:" + result4);


        }

        // Methods Here
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static decimal Divide(int a, int b)
        {
            return a / b;
    }
 }
}