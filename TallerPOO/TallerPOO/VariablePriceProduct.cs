namespace TallerPOO
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        //decimal Value = 0;
        
        public override decimal ValueToPay()
        {
            return ((decimal)Quantity * Price) + (decimal)Tax * ((decimal)Quantity * Price);
        }
        public override string ToString()
        {
            return
               $"\n\t{Id} {Description} " +
               $"\n\t       Measurement.........: {$"{Measurement}"}" +
               $"\n\t       Quantity............: {$"{Quantity:N2}"}" +
               $"\n\t       Price...............: {$"{Price:C2}"}" +
               $"\n\t       Tax.................: {$"{Tax:P2}"}" +
               $"\n\t       Value to pay........: {$"{ValueToPay():C2}"}";
        }
    }
}
