namespace TallerPOO
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        decimal Value = 0;
        public override decimal ValueToPay()
        {
            return Value = ((decimal)Quantity * Price) + (decimal)Tax * Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
               $"\n\tDescription................: {$"{Description}",18}" +
               $"\n\tMeasurement...........: {$"{Measurement}",18}" +
               $"\n\tQuantity.........: {$"{Quantity:N2}",18}" +
               $"\n\tPrice...........: {$"{Price}",18}" +
               $"\n\tTax.........: {$"{Tax:P2}",18}" +
               $"\n\tValue to pay.........: {$"{ValueToPay():C2}",18}";
        }
    }
}
