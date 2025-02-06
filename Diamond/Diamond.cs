namespace Diamond;

public sealed class Diamond
{
    public static List<DiamondRow> Build(char input)
    {
        var diamondRowsCollection = new List<DiamondRow>();
        diamondRowsCollection.Add(new DiamondRow()
        {
            Character = input,
            InnerSpacesCount = 0,
            OuterSpacesCount = 0,
        });

        return diamondRowsCollection;
    }
}