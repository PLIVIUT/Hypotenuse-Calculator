namespace HypotenuseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter size a, b");

            Console.WriteLine("Enter the a size:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the b size:");
            double b = Convert.ToDouble(Console.ReadLine());

            double hypotenuse = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("You set a = {0}", a);
            Console.WriteLine("You set b = {0}", b);
            Console.WriteLine("The hypotenuse is {0}", hypotenuse);

            Console.ReadKey();
        }
    }
}