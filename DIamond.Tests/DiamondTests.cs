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
     *
     * As next step let's test the rows count for other inputs
     */
    [Theory]
    [InlineData('B', 3)]
    [InlineData('D', 7)]
    [InlineData('G', 13)]
    public void Given_validInput_Character_Build_returns_a_collection_of_expected_number_of_rows(char input, int expectedRowsCount)
    {
        var result = Diamond.Build(input);
        
        Assert.Equivalent(expectedRowsCount, result.Count);
    }
    
    /*
        Let's focus on building the row spacing, starting from outer spaces
        We need to introduce sorting too
     */
    [Fact]
    public void Given_validInput_C_Build_returns_a_collection_of_rows_with_correct_outer_spaces_count()
    {
        const char input = 'C';
        var diamondRowCollection = new List<DiamondRow>()
        {
            new DiamondRow() { OuterSpacesCount = 2, Character = 'A', InnerSpacesCount = 0, SortOrder = -2 },
            new DiamondRow() { OuterSpacesCount = 1, Character = 'B', InnerSpacesCount = 1, SortOrder = -1 },
            new DiamondRow() { OuterSpacesCount = 0, Character = 'C', InnerSpacesCount = 2, SortOrder = 0 },
            new DiamondRow() { OuterSpacesCount = 1, Character = 'B', InnerSpacesCount = 0, SortOrder = 1 },
            new DiamondRow() { OuterSpacesCount = 2, Character = 'A', InnerSpacesCount = 0, SortOrder = 2 },
        };
        
        var result = Diamond.Build(input);
        
        Assert.Equivalent(diamondRowCollection, result);
    }
}