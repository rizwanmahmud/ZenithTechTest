using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZenithCheckout;

[TestClass]
public class CheckoutTests
{
    [TestMethod]
    public void GetTotalPrice_ScanningItems_ReturnsCorrectTotal()
    {
        // Arrange
        Dictionary<char, int> prices = new Dictionary<char, int>
        {
            {'A', 50},
            {'B', 30},
            {'C', 20},
        };

        Dictionary<char, Tuple<int, int>> multiprices = new Dictionary<char, Tuple<int, int>>
        {
            {'A', Tuple.Create(3, 130)},
        };

        Checkout checkout = new Checkout(prices, multiprices);

        // Act
        checkout.Scan("A");
        checkout.Scan("B");
        checkout.Scan("A");
        checkout.Scan("C");

        int total = checkout.GetTotalPrice();

        // Assert
        Assert.AreEqual(95, total);
    }
}