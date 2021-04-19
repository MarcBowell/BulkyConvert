using System.Linq;
using Marcware.BulkyConvert.Converters.Service;
using Marcware.BulkyConvert.ExtensionMethods;

namespace Marcware.BulkyConvert.Converters.ConverterClasses.Temperature
{
    public class CelsiusToGasMarkConverter : CoreUnitConverter
    {
        public CelsiusToGasMarkConverter(MeasurementUnit inputUnit, MeasurementUnit outputUnit, string unitDomain, bool isFrequentlyUsedConverter) : base(inputUnit, outputUnit, unitDomain, isFrequentlyUsedConverter)
        {
        }        

        public override double GetConversion(double input)
        {
            double result = 0;            
            if (input > (TemperatureConstants.GasMarkToCelsius.FirstOrDefault() / 2))
                result = TemperatureConstants.GasMarkToCelsius.GetNearestItemNumber(input) + 1;
            return result;
        }

        public override double GetReverseConversion(double value)
        {
            int gasMark = (int)value;
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
    }
}
