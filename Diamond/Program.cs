using Diamond;

if (args.Length != 1 ||
    args[0].Length != 1)
{
    Console.WriteLine("Usage: (Windows) Diamond.exe [Uppercase character] or (Osx/Linux) ./Diamond [Uppercase character]");
    return;
}

var inputChar = args[0][0];

var printer = new DiamondPrinter();
printer.Print(inputChar);