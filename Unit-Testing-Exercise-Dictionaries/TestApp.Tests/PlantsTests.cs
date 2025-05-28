using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = Array.Empty<string>();

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "rose" };
        string expected = "Plants with 4 letters:" 
                          + Environment.NewLine
                          + "rose";

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] { "rose", "lavender", "hibiscus", "aloe", "lemon", "papaya" };
        string expected = "Plants with 4 letters:"
                          + Environment.NewLine
                          + "rose"
                          + Environment.NewLine
                          + "aloe"
                          + Environment.NewLine
                          + "Plants with 5 letters:"
                          + Environment.NewLine
                          + "lemon"
                          + Environment.NewLine
                          + "Plants with 6 letters:"
                          + Environment.NewLine
                          + "papaya"
                          + Environment.NewLine
                          + "Plants with 8 letters:"
                          + Environment.NewLine
                          + "lavender"
                          + Environment.NewLine
                          + "hibiscus";

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "Rose", "LAVENDER", "Aloe Vera", "leMON", "PaPaya" };
        string expected = "Plants with 4 letters:"
                          + Environment.NewLine
                          + "Rose"
                          + Environment.NewLine
                          + "Plants with 5 letters:"
                          + Environment.NewLine
                          + "leMON"
                          + Environment.NewLine
                          + "Plants with 6 letters:"
                          + Environment.NewLine
                          + "PaPaya"
                          + Environment.NewLine
                          + "Plants with 8 letters:"
                          + Environment.NewLine
                          + "LAVENDER"
                          + Environment.NewLine
                          + "Plants with 9 letters:"
                          + Environment.NewLine
                          + "Aloe Vera";
                          

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
