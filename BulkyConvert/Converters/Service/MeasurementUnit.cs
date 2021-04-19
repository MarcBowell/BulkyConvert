namespace Marcware.BulkyConvert.Converters.Service
{
    public class MeasurementUnit
    {
        public MeasurementUnit(string singularName, string pluralName, string abbreviation)
        {
            SingularName = singularName;
            PluralName = pluralName;
            Abbreviation = abbreviation;
        }

        public string Abbreviation { get; private set; }

        public string SingularName { get; private set; }

        public string PluralName { get; private set; }
    }
}
