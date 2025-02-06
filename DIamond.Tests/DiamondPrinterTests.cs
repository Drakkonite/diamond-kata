namespace Diamond.Tests;

public class DiamondPrinterTests
{
    /*
     * I need to start seeing the printout of the diamond in the console.
     * I will start by writing a test that checks if the diamond is printed to the console. I will use a StringWriter to capture the output.
     * Then I will compare the captured output with the expected output. 
     * If they match, then the test passes. 
     * If they don't match, then the test fails. 
     * This will help me ensure that the diamond is printed correctly. 
     */
    [Fact]
    public void Goven_validInput_DiamondPrinter_prints_diamond_to_console()
    {
        // Arrange
        var input = 'C';
        var diamondPrinter = new DiamondPrinter();
        var expectedOutput = "  A  \n B B \nC   C\n B B \n  A  \n";   
        
        using var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        diamondPrinter.Print(input);
        var actualOutput = consoleOutput.ToString();
        
        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }
    
}