using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageDay1
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; }
        public DateTime MfgDate { get; set; }
        public int Warranty { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public decimal Gst { get; set; }
        public decimal Discount { get; set; }

        public string Display()
        {
            decimal taxPrice = Price + Price * Gst;
            decimal discountPrice = taxPrice * (1 - Discount);
            decimal totalPrice = discountPrice * Stock;

            return $"ProdId: {ProductId}, " +
                $"Name: {ProdName}, " +
                $"MfgDate: {MfgDate}, " +
                $"TaxPrice: {taxPrice}, " +
                $"DiscountPrice: {discountPrice}, " +
                $"TotalPrice: {totalPrice}";
        }
    }

}
