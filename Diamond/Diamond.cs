namespace Diamond;

public sealed class Diamond
{
    private const char StartingCharacter = 'A';
    public static List<DiamondRow> Build(char input)
    {
        // We are calculating the distance by considering ASCII codes integer representation
        var characterDistance = input - StartingCharacter;
        // number of spaces around character are equal the distance from 'A'
        // we can calculate row length by multiplying distance by 2 and adding 1 to count the character
        var totalRowLength = characterDistance * 2 + 1;
        var diamondRowsCollection = new List<DiamondRow>();
        // We are moving around the middle of the row 
        for (var i = -characterDistance; i <= characterDistance; i++)
        {
            diamondRowsCollection.Add(CreateDiamondRow(i, characterDistance, totalRowLength));
        }

        return diamondRowsCollection.OrderBy(p=>p.SortOrder).ToList();;
    }

    private static DiamondRow CreateDiamondRow(int currentLineIndex, int characterDistance, int totalRowLength)
    {
        // we are using this index to position rows in the list to allow easy printout
        var newRow = new DiamondRow() { SortOrder = currentLineIndex };
        
        // using Math.Abs to always have positive number, even on negative sort order index
        var outerSpacesCount = Math.Abs(currentLineIndex); 
        // we know the number of outer spaces now
        newRow.OuterSpacesCount = outerSpacesCount;
        // calculate the actual character for this row
        newRow.Character = (char)(StartingCharacter + characterDistance - outerSpacesCount);

        return newRow;
    }
}