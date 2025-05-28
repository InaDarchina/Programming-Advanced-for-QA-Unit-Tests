using Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Helpers;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    // TODO: finish the test
    [TestCase("ala@bala.com")]
    [TestCase("bo@gmail.com")]
    [TestCase("bot@bot.bg")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish the test
    [TestCase("ala bala.com")]
    [TestCase("@.gmail.bg")]
    [TestCase("bot@bg")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
