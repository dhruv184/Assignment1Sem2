using System;
namespace Assignment1
{
	public class Bill
	{
        private string userName;
        private double price;
        private int itemNumber;

        public string Name { get; set; }
        public double pricePerItem { get; set; }
        public int numberOfItems { get; set; }
        public double Discount { get; set; }

        public Bill(string userName, double price, int itemNumber, double discount)
        {
            Name = userName;
            pricePerItem = price;
            numberOfItems = itemNumber;
            Discount = discount;
        }
    }
}

