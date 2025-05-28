using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange 
        string[] input = Array.Empty<string>();

        //Act
        string actual = Miner.Mine(input);

        //Assert
        Assert.That(actual, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "GOld 2", "gOLd 6", "SILVER 5", "sIlVer 12", "silveR 13"};
        

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = new string[] { "gold 23", "silver 12", "copper 18", "gold 7", "iron 100", "iron 25" };

        // Act
        string actual = Miner.Mine(input);

        // Assert 
        Assert.That(actual, Is.EqualTo($"gold -> 30"
                                       + Environment.NewLine
                                       + "silver -> 12"
                                       + Environment.NewLine
                                       + "copper -> 18"
                                       + Environment.NewLine
                                       + "iron -> 125"));
    }
}
