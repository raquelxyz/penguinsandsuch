using CsvHelper;
using CsvHelper.Configuration;
public class CsvHelperMap : ClassMap<CsvHelperObject>
{
    public CsvHelperMap()
    {
        Map(m => m.Species)
            .Name("species")
            .TypeConverterOption.NullValues("NA", "N/A", "");
        Map(m => m.Island)
            .Name("island")
            .TypeConverterOption.NullValues("NA", "N/A", "");
        Map(m => m.Length)
            .Name("culmen_length_mm")
            .TypeConverterOption.NullValues("NA", "N/A", "");
        Map(m => m.Depth)
            .Name("culmen_depth_mm")
            .TypeConverterOption.NullValues("NA", "N/A", "");
        Map(m => m.FlipperLength)
            .Name("flipper_length_mm")
            .TypeConverterOption.NullValues("NA", "N/A", "");
        Map(m => m.BodyMass)
            .Name("body_mass_g")
            .TypeConverterOption.NullValues("NA", "N/A", "");
        Map(m => m.Sex)
            .Name("sex")
            .TypeConverterOption.NullValues("NA", "N/A", "");
    }
}