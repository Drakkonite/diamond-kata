namespace Diamond;

public sealed class Diamond
{
    private const char StartingCharacter = 'A';
    public static List<DiamondRow> Build(char input)
    {
        // We are calculating the distance by considering ASCII codes integer representation
        var characterDistance = input - StartingCharacter;

        var diamondRowsCollection = new List<DiamondRow>();
        // We are moving around the middle of the row 
        for (var i = -characterDistance; i <= characterDistance; i++)
        {
            diamondRowsCollection.Add(new DiamondRow() { Character = 'A', InnerSpacesCount = 0, OuterSpacesCount = 0});
        }

        return diamondRowsCollection;
    }
}