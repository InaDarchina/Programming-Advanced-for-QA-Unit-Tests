﻿using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
        string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        string actual = MatchPhoneNumbers.Match(phoneNumbers);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
    {
        // Arrange
        string phoneNumbers = "+359-2124-5678, +359 2/986/5432, +359-2-5556-555";
        string expected = string.Empty; 

        // Act
        string actual = MatchPhoneNumbers.Match(phoneNumbers);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string phoneNumbers = "";
        string expected = "";

        // Act
        string actual = MatchPhoneNumbers.Match(phoneNumbers);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359/2/986/5432, +359-2-555-5555";
        string expected = "+359-2-124-5678, +359-2-555-5555";

        // Act
        string actual = MatchPhoneNumbers.Match(phoneNumbers);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
