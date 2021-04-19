using System.Linq;
using Marcware.BulkyConvert.Converters.Service;
using Marcware.BulkyConvert.ExtensionMethods;

namespace Marcware.BulkyConvert.Converters.ConverterClasses.Temperature
{
    public class GasMarkToCelsiusConverter : CoreUnitConverter
    {
        public GasMarkToCelsiusConverter(MeasurementUnit inputUnit, MeasurementUnit outputUnit, string unitDomain, bool isFrequentlyUsedConverter) : base(inputUnit, outputUnit, unitDomain, isFrequentlyUsedConverter)
        {
        }

        public override double GetConversion(double input)
        {
            int gasMark = (int)input;
            double result = 0;

            if (gasMark > 0)
            {
                if (gasMark > 10)
                    result = TemperatureConstants.GasMarkToCelsius.Last();
                else
                    result = TemperatureConstants.GasMarkToCelsius[gasMark - 1];
            }

            return result;
        }

        public override double GetReverseConversion(double value)
        {
            double result = 0;
            if (value > (TemperatureConstants.GasMarkToCelsius.FirstOrDefault() / 2))
                result = TemperatureConstants.GasMarkToCelsius.GetNearestItemNumber(value) + 1;
            return result;
        }
    }
}
