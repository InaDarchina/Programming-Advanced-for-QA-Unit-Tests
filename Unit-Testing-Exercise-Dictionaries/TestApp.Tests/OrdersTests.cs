using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange 
        string[] orders = Array.Empty<string>();

        // Act
        string actual = Orders.Order(orders);

        // Assert 
        Assert.That(actual, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] orders = new string[] { "apples 5.97 1", "banana 3.75 1", "oranges 1.98 1" };

        // Act
        string actual = Orders.Order(orders);

        // Assert
        Assert.That(actual, Is.EqualTo($"apples -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}oranges -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] orders = new string[] { "apples 3.50 2", "banana 4.25 3", "oranges 3.00 4" };

        // Act
        string actual = Orders.Order(orders);

        // Assert
        Assert.That(actual, Is.EqualTo($"apples -> 7.00{Environment.NewLine}banana -> 12.75{Environment.NewLine}oranges -> 12.00"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {

        // Arrange
        string[] orders = new string[] { "apples 3 2.69", "banana 3 3.50", "oranges 3 4.25" };

        // Act
        string actual = Orders.Order(orders);

        // Assert
        Assert.That(actual, Is.EqualTo($"apples -> 8.07{Environment.NewLine}banana -> 10.50{Environment.NewLine}oranges -> 12.75"));
    }
}
