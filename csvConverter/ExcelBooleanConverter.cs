using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace csvConverter;

public class ExcelBooleanConverter : DefaultTypeConverter
{
    public override object? ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
    {
        return text == "WAHR";
    }
}