using System.Text;

namespace Diamond;

public sealed class DiamondPrinter
{
    public void Print(char input)
    {
        const char spacer = ' ';
        var diamond = Diamond.Build(input);
        foreach (var diamondRow in diamond)
        {
            var builder = new StringBuilder();
            builder.Append(spacer, diamondRow.OuterSpacesCount);
            builder.Append(diamondRow.Character);

            if (diamondRow.InnerSpacesCount > 0)
            {
                builder.Append(spacer, diamondRow.InnerSpacesCount);
                builder.Append(diamondRow.Character);
            }
            builder.Append(spacer, diamondRow.OuterSpacesCount);
            Console.WriteLine(builder);
        }
    }
}