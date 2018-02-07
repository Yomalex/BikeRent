using System;
using System.Collections.Generic;
using System.Text;

namespace BikeRent
{
    public class Bill
    {
        private List<Rent> items;
        private string Buyer;
        private string Direction;
        private string PhoneNumber;
        private float subtotal;
        private float iva;
        private float discount;

        public Bill(string buyer, string dir, string phone)
        {
            Buyer = buyer;
            Direction = dir;
            PhoneNumber = phone;
            discount = 0;
            items = new List<Rent>();
        }

        public int Add(float amount, string desc, RentType type)
        {
            var item = new Rent(amount, desc, type);
            items.Add(item);

            subtotal += item.SubTotal;
            iva = subtotal * RentConst.Iva;

            return items.Count;
        }

        public void Remove(int item)
        {
            if(item < 1 || item > items.Count)
            {
                throw new ArgumentOutOfRangeException("item");
            }

            item -= 1;
            items.RemoveAt(item);

            subtotal = 0;
            foreach(var it in items)
            {
                subtotal += it.SubTotal;
            }
            iva = subtotal * RentConst.Iva;
        }

        public float SubTotal => subtotal;
        public float Discount => discount * subtotal;
        public float Iva => iva;
        public float Total()
        {
            // Promotion
            if (items.Count >= 3 && items.Count <= 5)
            {
                discount = RentConst.FamilyRental;
            }

            return subtotal - Discount + Iva;
        }
        public string Name => Buyer;
        public string Address => Direction;
        public string Contact => PhoneNumber;
    }
}
