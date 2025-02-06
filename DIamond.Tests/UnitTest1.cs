﻿namespace DIamond.Tests;

public class UnitTest1
{
    // Start with the simplest happy path, build diamond with letter A for input A
    [Fact]
    public void Given_validInput_A_BuildDiamondWithA()
    {
        var result = Diamond.Build('A');
        Assert.Equal("A", result);
    }
}

public sealed class Diamond
{
    public static string Build(char input)
    {
        return input.ToString();
    }
}