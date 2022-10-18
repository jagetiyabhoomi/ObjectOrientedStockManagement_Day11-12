using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class StockReport
    {
        public List<Stock> stocks;
    }
    public class Stock
    {
        public string Name { get; set; }
        public int NumberofShares { get; set; }
        public int SharePrice { get; set; }

    }
}
