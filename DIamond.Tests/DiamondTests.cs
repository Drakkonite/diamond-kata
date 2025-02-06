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
     *
     * Moving forward Diamond consists of multiple ordered rows, so return value needs to be a collection
     */
    [Fact]
    public void Given_validInput_A_Build_returns_a_collection_of_rows_with_single_row_with_A()
    {
        const char input = 'A';
        var diamondRowCollection = new List<DiamondRow>()
        {
            new DiamondRow() { 
                OuterSpacesCount = 0,
                Character = 'A',
                InnerSpacesCount = 0
            }
        };
        
        var result = Diamond.Build(input);
        
        Assert.Equivalent(diamondRowCollection, result);
    }
    
    /*
     * Switching to a more advanced scenario, the further the input letter is from 'A' the more rows we should get
     * For 'B' we should get
     * - 2x 'B' rows
     * - 1x 'A' row
     * Total 3
     */
    [Fact]
    public void Given_validInput_B_Build_returns_a_collection_of_3_rows()
    {
        const char input = 'B';
        
        var result = Diamond.Build(input);
        
        Assert.Equivalent(3, result.Count);
    }
    
}