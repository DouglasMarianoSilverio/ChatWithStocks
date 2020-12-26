using System;
using System.Collections.Generic;
using System.Text;

namespace ChatWithStocks.Domain
{
    public class Stock
    {
        public string Symbol { get; set; }
        public Decimal Close { get; set; }

        public string GetQuote()
        {
            var quote = Close.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"));
            return $"{Symbol} quote is {quote} per share";
        }


    }
}
