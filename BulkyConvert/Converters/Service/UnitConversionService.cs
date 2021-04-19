using System.Collections.Generic;
using System.Linq;
using Marcware.BulkyConvert.Converters.ConverterClasses;
using Marcware.BulkyConvert.Converters.ConverterClasses.Temperature;

namespace Marcware.BulkyConvert.Converters.Service
{
    public class UnitConversionService : IUnitConversionService
    {
        private struct LengthUnits
        {
            public readonly static MeasurementUnit Yard = new MeasurementUnit("Yard", "Yards", "yd");
            public readonly static MeasurementUnit Mile = new MeasurementUnit("Mile", "Miles", "mile");
            public readonly static MeasurementUnit Kilometres = new MeasurementUnit("Kilometre", "Kilometers", "km");
        }

        private struct TemperatureUnits
        {
            public readonly static MeasurementUnit Fahrenheit = new MeasurementUnit("Fahrenheit", "Fahrenheit", "F");
            public readonly static MeasurementUnit Celsius = new MeasurementUnit("Celsius", "Celsius", "C");
            public readonly static MeasurementUnit GasMark = new MeasurementUnit("Gas Mark", "Gas Mark", "GM");
        }

        private struct UnitDomains
        {
            public const string Length = "Length";
            public const string Temperature = "Temperature";
        }

        private readonly List<CoreUnitConverter> AllConverters;

        public UnitConversionService()
        {
            // Register all converters
            AllConverters = new List<CoreUnitConverter>()
            {
                new StandardUnitConverter(LengthUnits.Yard, LengthUnits.Mile, UnitDomains.Length, 0.000568, false),
                new StandardUnitConverter(LengthUnits.Yard, LengthUnits.Kilometres, UnitDomains.Length, 0.000914, false),
                new StandardUnitConverter(LengthUnits.Mile, LengthUnits.Yard, UnitDomains.Length, 1760, false),
                new StandardUnitConverter(LengthUnits.Mile, LengthUnits.Kilometres, UnitDomains.Length, 1.609344, false),
                new StandardUnitConverter(LengthUnits.Kilometres, LengthUnits.Yard, UnitDomains.Length, 1093.6133, false),
                new StandardUnitConverter(LengthUnits.Kilometres, LengthUnits.Mile, UnitDomains.Length, 0.621371, true),
                new FahrenheitToCelciusConverter(TemperatureUnits.Fahrenheit, TemperatureUnits.Celsius, UnitDomains.Temperature, false),
                new FahrenheitToGasMarkConverter(TemperatureUnits.Fahrenheit, TemperatureUnits.GasMark, UnitDomains.Temperature, true),
                new CelciusToFahrenheitConverter(TemperatureUnits.Celsius, TemperatureUnits.Fahrenheit, UnitDomains.Temperature, false),
                new CelsiusToGasMarkConverter(TemperatureUnits.Celsius, TemperatureUnits.GasMark, UnitDomains.Temperature, false),
                new GasMarkToCelsiusConverter(TemperatureUnits.GasMark, TemperatureUnits.Celsius, UnitDomains.Temperature, true),
                new GasMarkToFahrenheitConverter(TemperatureUnits.GasMark, TemperatureUnits.Fahrenheit, UnitDomains.Temperature, false)                
            };
        }

        public CoreUnitConverter GetUnitConverter(string name)
        {
            return AllConverters.FirstOrDefault(c => c.Name == name);
        }

        public List<CoreUnitConverter> GetAllUnitConverters()
        {
            return AllConverters;
        }
    }
}
