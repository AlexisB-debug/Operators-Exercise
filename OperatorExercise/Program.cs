namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int subtraction = a - b;
            int multiplication = a * b;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What's the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the circle whose radius is {radius} is {AreaOfCircle(radius)}");

            ThoughtExercise();
        }

        static double AreaOfCircle(double radius)
        {
            double theAreaOftheCircle = Math.PI * Math.Pow(radius, 2);
            return theAreaOftheCircle;
        }

        static void ThoughtExercise()
        {
            Console.WriteLine("int i = 3\n int j = 4\n int k = ++i * j++\n What's the value of int k?");
            int greenCheckMark = int.Parse(Console.ReadLine());
            if (greenCheckMark == RedCrossMark())
            {
                Console.WriteLine("Green Check Mark!");
            }
            else if (greenCheckMark != RedCrossMark())
            {
                Console.WriteLine($"Oops, Red Cross Mark! The correct answer is {RedCrossMark()}!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }

        static int RedCrossMark()
        {
            int i = 3;
            int j = 4;
            int k = ++i * j++;
            return k;
        }
    }
}
