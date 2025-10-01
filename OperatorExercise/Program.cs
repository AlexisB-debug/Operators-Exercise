namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int sum = a+b;
            int subtraction = a-b;
            int multiplication = a*b;
            
            int quotient = a/b;
            int remainder = a%b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What's the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the circle whose radius is {radius} is {AreaOfCircle(radius)}");
        }

        static double AreaOfCircle(double radius)
        {
          double theAreaOftheCircle = Math.PI * Math.Pow(radius, 2);
          return theAreaOftheCircle;
        }
    }
}
