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

        public string ToString(string? format, IFormatProvider? formatProvider) // format = thr string that tell you what to do / formatProvider is en-GB or es-ES
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "kg";
            }

            double convertedWeight = 0;
            string unit = "";

            switch(format.ToLower())
            {
                case "kg":
                    //
                    convertedWeight = _animal.WeightInKg;
                    unit = "kilograms";
                    break;
                case "oz":
                    //
                    convertedWeight = _animal.WeightInKg * 35.274;
                    unit = "ounces";
                    break;
                default:
                    //
                    convertedWeight = _animal.WeightInKg;
                    unit = "kilograms";
                    break;
            }

            return $"This {_animal.GetType().Name}'s weight is {convertedWeight.ToString("N", formatProvider)} {unit}.";
        }
    }
}
