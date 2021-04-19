using System.Collections.Generic;
using Marcware.BulkyConvert.Converters.ConverterClasses;

namespace Marcware.BulkyConvert.Converters.Service
{
    internal interface IUnitConversionService
    {
        /// <summary>
        /// Get the unit converter with the specified name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public CoreUnitConverter GetUnitConverter(string name);
        /// <summary>
        /// Get a collection of all supported unit conversions
        /// </summary>
        /// <returns></returns>
        public List<CoreUnitConverter> GetAllUnitConverters();
    }
}
