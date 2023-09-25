using CommandLine;

namespace csvConverter;

public class CommandLineOptions
{
    [Option('v', "debug", Required = false, HelpText = "Set output to verbose messages.")]
    public bool Verbose { get; set; }
    
    [Option('i', "input", Required = true, HelpText = "The input csv to convert.")]
    public string InputFile { get; set; }
    
    [Option('o', "output", Required = false, HelpText = "The output file.")]
    public string? OutputFile { get; set; }
}