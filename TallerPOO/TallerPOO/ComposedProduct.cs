namespace TallerPOO
{

    public class ComposedProduct : Product
    {

        /*Product product1 = new FixedPriceProduct()
        {
            Description = "Vino Gato Negro",
            Id = 1010,
            Price = 46000M,
            Tax = 0.19F
        };
        Product product2 = new FixedPriceProduct()
        {
            Description = "Pan Bimbo Artesanal",
            Id = 2020,
            Price = 1560M,
            Tax = 0.19F
        };
        Product product3 = new VariablePriceProduct()
        {
            Description = "Queso Holandes",
            Id = 3030,
            Measurement = "Kilo",
            Price = 32000M,
            Quantity = 0.536F,
            Tax = 0.19F
        };
        Product product4 = new VariablePriceProduct()
        {
            Description = "Cabano",
            Id = 4040,
            Measurement = "Kilo",
            Price = 18000M,
            Quantity = 0.389F,
            Tax = 0.19F
        };*/


        public float Discount { get; set; }
        public List<Product> Products { get; set; }

        
        public override decimal ValueToPay()
        {
            decimal Value = 0;
            foreach (Product product in Products)
            {
               Value += product.ValueToPay();
            }
            
            return Value - (Value * (decimal)Discount);


            /*return Value = product1.Price + product2.Price + product3.Price + product4.Price -
                (product1.Price + product2.Price + product3.Price + product4.Price) * (decimal)Discount;*/
        }

        public String NameProdcuts()
        {
            String nameProducts = "";
            foreach (Product product in Products)
            {
                nameProducts += product.Description + ", ";
            }
            return nameProducts;

        }

        public override string ToString()
        {
            return
              $"\n\t{Id} {Description} " +
              //$"\n\t        Products............: {$"{product1.Description}, {product2.Description}, {product3.Description}, {product4.Description}"}" +
              $"\n\t        Description............: {$"{NameProdcuts()}"}" +
              $"\n\t        Discount............: {$"{Discount:P2}"}" +
              $"\n\t        Value ..............: {$"{ValueToPay():C2}"}";
        }
    }
}
