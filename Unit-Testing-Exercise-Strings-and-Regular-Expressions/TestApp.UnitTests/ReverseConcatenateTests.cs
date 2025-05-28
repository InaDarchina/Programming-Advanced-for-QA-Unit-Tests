using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string expected = string.Empty;
        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        
    }

    
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = new string[] { "summer" };
        string expected = "summer";
        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));


    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "summer", "is", "magic" };
        string expected = "magicissummer";
        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = null;
        string expected = string.Empty;
        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "coffee", " ", "is", " ", "hot" };
        string expected = "hot is coffee";
        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "summer", "is", "the", "best", "season" };
        string expected = "seasonbesttheissummer";
        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
