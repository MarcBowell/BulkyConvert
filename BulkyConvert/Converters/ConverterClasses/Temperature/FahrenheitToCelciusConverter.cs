using Marcware.BulkyConvert.Converters.Service;

namespace Marcware.BulkyConvert.Converters.ConverterClasses.Temperature
{
    public class FahrenheitToCelciusConverter : CoreUnitConverter
    {
        public FahrenheitToCelciusConverter(MeasurementUnit inputUnit, MeasurementUnit outputUnit, string unitDomain, bool isFrequentlyUsedConverter) : base(inputUnit, outputUnit, unitDomain, isFrequentlyUsedConverter)
        {
        }

        public override double GetConversion(double input)
        {
            return (input - 32) * 5 / 9;
        }

        public override double GetReverseConversion(double value)
        {
            return (value * 9 / 5) + 32;
        }
    }
}
