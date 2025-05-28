using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] words = Array.Empty<string>();

        // Act
        string actual = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(actual, Is.Empty); 
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] words = new string[] { "hello", "hello" };

        // Act
        string actual = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] words = new string[] { "sunshine", "sunshine", "sunshine" };
        string expected = "sunshine";

        // Act
        string actual = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] words = new string[] { "sunshine", "icecream", "icecream", "stars", "dog" };
        string expected = "sunshine stars dog";

        // Act
        string actual = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] words = new string[] { "SEA", "icecream", "iceCream", "Icecream", "DoG", "HoUse"};
        string expected = "sea icecream dog house";
        // Act
        string actual = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
