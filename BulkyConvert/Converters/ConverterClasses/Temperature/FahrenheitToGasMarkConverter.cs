using System.Linq;
using Marcware.BulkyConvert.Converters.Service;
using Marcware.BulkyConvert.ExtensionMethods;

namespace Marcware.BulkyConvert.Converters.ConverterClasses.Temperature
{
    public class FahrenheitToGasMarkConverter : CoreUnitConverter
    {
        public FahrenheitToGasMarkConverter(MeasurementUnit inputUnit, MeasurementUnit outputUnit, string unitDomain, bool isFrequentlyUsedConverter) : base(inputUnit, outputUnit, unitDomain, isFrequentlyUsedConverter)
        {
        }

        public override double GetConversion(double input)
        {
            double result = 0;
            if (input > (TemperatureConstants.GasMarkToFahrenheit.FirstOrDefault() / 2))
                result = TemperatureConstants.GasMarkToFahrenheit.GetNearestItemNumber(input) + 1;
            return result;
        }

        public override double GetReverseConversion(double value)
        {
            int gasMark = (int)value;
            double result = 0;

            if (gasMark > 0)
            {
                if (gasMark > 10)
                    result = TemperatureConstants.GasMarkToFahrenheit.Last();
                else
                    result = TemperatureConstants.GasMarkToFahrenheit[gasMark - 1];
            }

            return result;
        }
    }
}
