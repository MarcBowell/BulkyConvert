using Marcware.BulkyConvert.Converters.Service;

namespace Marcware.BulkyConvert.Converters.ConverterClasses
{
    public class StandardUnitConverter : CoreUnitConverter
    {
        public StandardUnitConverter(MeasurementUnit inputUnit, MeasurementUnit outputUnit, string unitDomain, double multiplier, bool isFrequentlyUsedConverter) : base(inputUnit, outputUnit, unitDomain, isFrequentlyUsedConverter)
        {
            Multiplier = multiplier;
        }

        public double Multiplier { get; set; }

        public override double GetConversion(double input) => (input * Multiplier);

        public override double GetReverseConversion(double value) => (value / Multiplier);
    }
}
