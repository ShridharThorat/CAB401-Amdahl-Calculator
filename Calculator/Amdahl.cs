namespace Calculator
{
    public class Amdahl
    {
        public double bestSequentialTime; // in seconds
        public double bestParallelTime; // in seconds
        public double percentParallelisable; // between 0 and 1

        public Amdahl()
        {
            this.bestSequentialTime = 0;
            this.bestParallelTime = 0;
            this.percentParallelisable = 0;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        private static void Main(string[] args)
        {        
            Console.Write("Write a number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write another number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The result is: " + Multiply(x, y));
        }
    }
}