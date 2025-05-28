using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { };
        string text = "Hello baby";
        string expected = text;

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new string[] { "baby" }; 
        string text = "Hello dear baby";
        string expected = "Hello dear ****";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string text = "Little bird fly away";
        string expected = "Little bird fly away";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new string[] {" "};
        string text = "Hello sunshine have a nice day";
        string expected = "Hello*sunshine*have*a*nice*day";

        // Act
        string actual = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
