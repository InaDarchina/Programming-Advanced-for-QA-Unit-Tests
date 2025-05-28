using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string>() {"", ""};

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "a" };
        string expected = "a -> 1";
        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "ala", "bala", "baby" };
        string expected = $"a -> 5"
                           + Environment.NewLine 
                           + "l -> 2"
                           + Environment.NewLine
                           + "b -> 3"
                           + Environment.NewLine 
                           + "y -> 1";
                         
        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string>() { "go!", "-", "baby-!" };
        string expected = $"g -> 1"
                           + Environment.NewLine
                           + "o -> 1"
                           + Environment.NewLine
                           + "! -> 2"
                           + Environment.NewLine
                           + "- -> 2"
                           + Environment.NewLine
                           + "b -> 2"
                           + Environment.NewLine
                           + "a -> 1"
                           + Environment.NewLine
                           + "y -> 1";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
