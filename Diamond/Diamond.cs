namespace Diamond;

public sealed class Diamond
{
    public static DiamondRow Build(char input)
    {
        return new DiamondRow()
        {
            Character = input,
            InnerSpacesCount = 0,
            OuterSpacesCount = 0,
        };
    }
}