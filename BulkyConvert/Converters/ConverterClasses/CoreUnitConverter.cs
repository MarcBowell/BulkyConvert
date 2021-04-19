using Marcware.BulkyConvert.Converters.Service;

namespace Marcware.BulkyConvert.Converters.ConverterClasses
{
    public abstract class CoreUnitConverter
    {
        public CoreUnitConverter(MeasurementUnit inputUnit, MeasurementUnit outputUnit, string unitDomain, bool isFrequentlyUsedConverter)
        {
            InputUnit = inputUnit;
            OutputUnit = outputUnit;
            UnitDomain = unitDomain;
            IsFrequentlyUsedConverter = isFrequentlyUsedConverter;
        }

        public string Name => $"{InputUnit.PluralName.Replace(" ", string.Empty)}To{OutputUnit.SingularName.Replace(" ", string.Empty)}";

        /// <summary>
        /// Domain of the unit (length, area etc.)
        /// </summary>
        public string UnitDomain { get; private set; }

        /// <summary>
        /// Input unit
        /// </summary>
        public MeasurementUnit InputUnit { get; private set; }

        /// <summary>
        /// Output unit
        /// </summary>
        public MeasurementUnit OutputUnit { get; private set; }

        /// <summary>
        /// Is this converter frequently used?
        /// </summary>
        public bool IsFrequentlyUsedConverter { get; private set; }

        /// <summary>
        /// Get the converted rate from the input unit to the output unit
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public abstract double GetConversion(double input);

        /// <summary>
        /// Get the reverse conversion from the output unit to the input unit
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public abstract double GetReverseConversion(double value);
    }
}
