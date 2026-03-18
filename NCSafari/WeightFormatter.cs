using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
// System.Globalization.CultureInfo;

namespace NCSafari
{
    internal class WeightFormatter : IFormattable
    {
        private readonly Animal _animal;
        public WeightFormatter(Animal animal)
        {
            _animal = animal;
        }

        public string ToString(string? format, IFormatProvider? formatProvider) // format = the string that tell you what to do / formatProvider is "en-GB" or "es-ES" depending on the CultureInfo we passed
        {
            if (string.IsNullOrEmpty(format)) // handle null and empty cases
            {
                format = "kg";
            }

            double convertedWeight = 0;
            string unit = "";

            switch(format.ToLower()) // we normalize the `format` string
            {
                case "kg": // if the format is "kg" then the weight = to the animal.WeightInKg:
                    convertedWeight = _animal.WeightInKg;
                    unit = "kilograms"; // this because exercise asks to specify the unit aftet the weight
                    break;
                case "oz": // if the format is "oz", we need to convert kg -> oz:
                    convertedWeight = _animal.WeightInKg * 35.274; // 1kg = 35.274oz
                    unit = "ounces";
                    break;
                default:
                    convertedWeight = _animal.WeightInKg; // defaulted to kg because we need a default in a `switch`
                    unit = "kilograms";
                    break;
            }
            // convertedWeight.ToString("N2", formatProvider) -> "N2" means format this num to be a double with 2 decimals
            return $"This {_animal.GetType().Name}'s weight is {convertedWeight.ToString("N2", formatProvider)} {unit}.";
        }
    }
}
