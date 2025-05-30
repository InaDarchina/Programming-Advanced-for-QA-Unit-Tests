﻿using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> numbers = new List<int>();
        string expected = string.Empty;

        // Act
        string actual = Grouping.GroupNumbers(numbers);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7};
        string expected = $"Odd numbers: 1, 3, 5, 7"
                          + Environment.NewLine
                          + "Even numbers: 2, 4, 6";

        // Act
        string actual = Grouping.GroupNumbers(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> numbers = new List<int>() { 4, 8, 12, 22, 10 };
        string expected = "Even numbers: 4, 8, 12, 22, 10";

        // Act
        string actual = Grouping.GroupNumbers(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 7, 13, 15, 9, 11 };
        string expected = "Odd numbers: 1, 7, 13, 15, 9, 11";

        // Act
        string actual = Grouping.GroupNumbers(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> numbers = new List<int>() { -1, -2, -3, -4, -5, -6, -7 };
        string expected = $"Odd numbers: -1, -3, -5, -7"
                          + Environment.NewLine
                          + "Even numbers: -2, -4, -6";

        // Act
        string actual = Grouping.GroupNumbers(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
