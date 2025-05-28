using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] numbers = Array.Empty <int>();
        // Act
        string actual = CountRealNumbers.Count(numbers);
        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new[] { 1 };
        string expected = "1 -> 1";

        // Act
        string actual = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new[] { 1, 1, 2, 8, 9, 2, 9, 13 };
        string expected = $"1 -> 2"
                           + Environment.NewLine 
                           + "2 -> 2"
                           + Environment.NewLine
                           + "8 -> 1"
                           + Environment.NewLine
                           + "9 -> 2"
                           + Environment.NewLine
                           + "13 -> 1";

        // Act
        string actual = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new[] { -1, -1, -2, -2, -9, -13, -9, -13 };
        string expected = $"-13 -> 2"
                           + Environment.NewLine
                           + "-9 -> 2"                         
                           + Environment.NewLine
                           + "-2 -> 2"
                           + Environment.NewLine
                           + "-1 -> 2";

        // Act
        string actual = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new[] { 0, 0, 0 };
        string expected = "0 -> 3";
                           

        // Act
        string actual = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
