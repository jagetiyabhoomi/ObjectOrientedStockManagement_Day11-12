using System.Diagnostics;

namespace StockManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            double temp = 0.0;
            string path = @"C:\Users\BHUMI\OneDrive\Desktop\Fellowship\StockManagement\StockManagement\StockInfo.json";
            FetchStock fetchStock = new FetchStock();
            StockReport data = fetchStock.Read(path);
            Console.WriteLine("___________");
            Console.WriteLine("--------------STOCK REPORT--------------");
            for(int i=0; i < data.stocks.Count; i++)
            {
                Console.WriteLine("Stock Name: "+data.stocks[i].Name);
                Console.WriteLine("Number of Stocks: " + data.stocks[i].NumberofShares);
                Console.WriteLine("Share price: " + data.stocks[i].SharePrice);
                double price = data.stocks[i].NumberofShares * data.stocks[i].SharePrice;
                Console.WriteLine("Total Price for " + data.stocks[i].Name + ":" + price);
                Console.WriteLine("--------------------------------------------------------------------");
                temp = temp + price;
            }
            Console.WriteLine("**********Final Price**********");
            Console.WriteLine("Total Share Price: "+temp);

        }
    }
}
