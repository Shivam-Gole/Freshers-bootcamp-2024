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
            double taxPrice = Price + Price * Gst;
            double discountPrice = taxPrice * (1 - Discount);
            double totalPrice = discountPrice * Stock;

            return $"ProdId: {ProductId}, " +
                $"Name: {ProdName}, " +
                $"MfgDate: {MfgDate}, " +
                $"TaxPrice: {taxPrice}, " +
                $"DiscountPrice: {discountPrice}, " +
                $"TotalPrice: {totalPrice}";
        }
    }
}
