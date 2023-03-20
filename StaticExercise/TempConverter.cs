using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double temp)
        {
            return (5* (temp - 32) / 9);
            //return ((5 / 9) * (temp - 32)); does not work, but why?
        }

        public static double CelsiusToFahrenheit(double temp)
        {
            return (temp * 9 / 5 + 32);
        }
    }
}
