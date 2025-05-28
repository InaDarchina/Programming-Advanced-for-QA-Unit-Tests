using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown jumps over the lazy dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "Brown";
        string input = "Brown lazy dog";
        string expected = "lazy dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "dog";
        string input = "Brown lazy dog";
        string expected = "Brown lazy";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "Brown lazy dog";
        string input = "Brown lazy dog";
        string expected = "";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
