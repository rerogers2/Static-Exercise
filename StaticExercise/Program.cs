namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("86 degree Fahrenheit converted to Celsius is: " + TempConverter.FahrenheitToCelsius(86));
            Console.WriteLine("-132.237 degree Celsius converted to Fahrenheit is: " + TempConverter.CelsiusToFahrenheit(-132.237));
        }
    }
}
