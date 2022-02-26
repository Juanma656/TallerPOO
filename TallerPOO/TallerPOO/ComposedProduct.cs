namespace TallerPOO
{

    public class ComposedProduct : Product
    {

        Product product1 = new FixedPriceProduct();

        Product product2 = new FixedPriceProduct();

        Product product3 = new VariablePriceProduct();

        Product product4 = new VariablePriceProduct();


        public float Discount { get; set; }
        public List<Product> Products { get; set; }

        decimal Value = 0;
        public override decimal ValueToPay()
        {
            return Value = (product1.Price + product2.Price + product3.Price + product4.Price) * (decimal)Discount;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
              $"\n\tDescription.........: {$"{Description}",18}" +
              $"\n\tProducts................: {$"{product1.Description}, {product2.Description}, {product3.Description}, {product4.Description}",18}" +
              $"\n\tDiscount...........: {$"{Discount:P2}",18}" +
              $"\n\tValue .........: {$"{ValueToPay():C2}",18}";
        }
    }
}
