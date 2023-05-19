using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conversorTemperatura
{
    public class ConverterTemperatura
    {
        // propiedade estática
        public static float temperatura;
        // método estático
        public static float CelsiusToFahreheint(float celsius)
        {
            float temperatura = celsius;

            float fahreheint = (temperatura * 9/5) + 32;

            return fahreheint;
        }

        public static float FahreheintToCelsius(float fahreheint)
        {
            float temperatura = fahreheint;

            float celsius = (temperatura  - 32) * 5/9;

            return celsius;
        }
    }
}