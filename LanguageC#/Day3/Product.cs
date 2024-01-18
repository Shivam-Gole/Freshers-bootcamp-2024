using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Product
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; }
        public DateTime MfgDate { get; set; }
        public int Warranty { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public double Gst { get; set; }
        public double Discount { get; set; }

        public string Display()
        {
            double taxPrice = Price + Price * Gst / 100;
            Price = taxPrice;
            double discountPrice = Discount / 100 * Price;
            double totalPrice = Price - discountPrice;

            return $"ProdId: {ProductId}, " +
                $"Name: {ProdName}, " +
                $"MfgDate: {MfgDate}, " +
                $"TaxPrice: {taxPrice}, " +
                $"DiscountPrice: {discountPrice}, " +
                $"TotalPrice: {totalPrice}";
        }
    }
}

