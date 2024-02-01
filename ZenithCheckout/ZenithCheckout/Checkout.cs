using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithCheckout
{
    public class Checkout : ICheckout
    {
        private readonly List<char> scannedItems;
        private readonly Dictionary<char, int> itemPrices;
        private readonly Dictionary<char, Tuple<int, int>> itemMultiprices;

        public int GetTotalPrice()
        {
            throw new NotImplementedException();
        }

        public void Scan(string item)
        {
            throw new NotImplementedException();
        }
    }
}
