using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithCheckout
{
    public class Checkout : ICheckout
    {
        /// <summary>
        /// List of char (A,B,C) 
        /// </summary>
        private readonly List<char> scannedItems;

        /// <summary>
        /// Dictionary of item prices in the format char, int e.g. A = 5
        /// </summary>
        private readonly Dictionary<char, int> itemPrices;

        /// <summary>
        /// Dictionary of multi item prices in the format char, int, int e.g. A = 5, 4
        /// </summary>
        private readonly Dictionary<char, Tuple<int, int>> itemMultiprices;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="multiprices"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Checkout(Dictionary<char, int> prices, Dictionary<char, Tuple<int, int>> multiprices)
        {
            itemPrices = prices ?? throw new ArgumentNullException(nameof(prices));
            itemMultiprices = multiprices ?? throw new ArgumentNullException(nameof(multiprices));
            scannedItems = new List<char>();
        }

        /// <summary>
        /// Get the total price of the checkout
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetTotalPrice()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Scan individual items.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Scan(string item)
        {
            if (item.Length != 1 || !char.IsLetter(item[0]))
            {
                throw new ArgumentException("Invalid item code");
            }

            char itemCode = char.ToUpper(item[0]);
            scannedItems.Add(itemCode);
        }
    }
}
