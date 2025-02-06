namespace Diamond.Tests;

public class DiamondTests
{
    /*
     * I need to represent diamond with some structure to allow testing and avoid
     * procedural flow with several for loops printing strings
     *
     * First return a row of diamond for input A
     * It consists of:
     * - preceeding and ending spaces count (it's always the same value for every row)
     * - row length it's represented by distance from INPUT char to 'A'
     * - inner spaces count - represents the number of spaces between characters in a row
     */
    [Fact]
    public void Given_validInput_A_BuildDiamond_returns_a_single_row_with_A()
    {
        const char input = 'A';
        var middlePointRow = new DiamondRow()
        {
            OuterSpacesCount = 0,
            Character = 'A',
            InnerSpacesCount = 0
        };
        
        var result = Diamond.Build(input);
        
        Assert.Equivalent(middlePointRow, result);
    }
    
}