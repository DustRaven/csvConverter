using System.Globalization;
using System.Text.Json;
using CommandLine;
using csvConverter;
using CsvHelper;
using CsvHelper.Configuration;
using SmartInvoice;

Parser.Default.ParseArguments<CommandLineOptions>(args)
    .WithParsed(RunOptions)
    .WithNotParsed(HandleParseError);

static void RunOptions(CommandLineOptions options)
{
    var config = new CsvConfiguration(CultureInfo.GetCultureInfo("de-DE"));
    using var reader = new StreamReader(options.InputFile);
    using (var csvReader = new CsvReader(reader, config))
    {
        csvReader.Context.TypeConverterCache.AddConverter<bool>(new ExcelBooleanConverter());
        var records = csvReader.GetRecords<VendorBankAccount>().ToList();
        var accounts = new VendorBankAccounts
        {
            BankAccounts = records
        };
        
        Console.WriteLine(JsonSerializer.Serialize(accounts));        
    }
}

static void HandleParseError(IEnumerable<Error> errors)
{
    foreach (var error in errors)
    {
        Console.WriteLine(error.Tag);
        Console.WriteLine(error.ToString());
    }
}