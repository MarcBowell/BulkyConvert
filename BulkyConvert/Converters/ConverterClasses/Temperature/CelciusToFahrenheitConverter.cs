using Marcware.BulkyConvert.Converters.Service;

namespace Marcware.BulkyConvert.Converters.ConverterClasses.Temperature
{
    internal class CelciusToFahrenheitConverter : CoreUnitConverter
    {
        public CelciusToFahrenheitConverter(MeasurementUnit inputUnit, MeasurementUnit outputUnit, string unitDomain, bool isFrequentlyUsedConverter) : base(inputUnit, outputUnit, unitDomain, isFrequentlyUsedConverter)
        {
        }

        public override double GetConversion(double input)
        {
            return (input * 9 / 5) + 32;
        }

        public override double GetReverseConversion(double value)
        {
            return (value - 32) * 5 / 9;
        }
    }
}
