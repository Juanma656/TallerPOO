namespace TallerPOO
{

    public class ComposedProduct : Product
    {

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
              $"\n\t        Description............: {$"{NameProdcuts()}"}" +
              $"\n\t        Discount............: {$"{Discount:P2}"}" +
              $"\n\t        Value ..............: {$"{ValueToPay():C2}"}";
        }
    }
}
