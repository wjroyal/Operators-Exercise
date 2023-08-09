namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var div = a / b;
            var mod = a % b;

            
            Console.WriteLine($"{a}/{b} is {div} remainder {mod}. ");
       
            //Allow user to input the radius of circle
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            //Calculate Area
            var areaOfCircle = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");

        }
      public static double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
