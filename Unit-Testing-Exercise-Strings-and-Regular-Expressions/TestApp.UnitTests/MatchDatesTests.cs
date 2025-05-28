using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "31-Dec-2022";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish the test
    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "12 02 1234, 23-Jan/2024, 17 Sep/2012, 28.Jun-1987";
        string expected = string.Empty;

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "18-Jul-2025, 12 02 1234, 23-Jan/2024, 17 Sep/2012, 28.Jun-1987";
        string expected = "Day: 18, Month: Jul, Year: 2025";

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expected = "";

        // Act
        string actual = MatchDates.Match(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string input = null;


        // Act + Assert
        Assert.That(() => MatchDates.Match(input), Throws.ArgumentException);

    }
}
