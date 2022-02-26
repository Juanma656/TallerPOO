namespace TallerPOO
{
    public class FixedPriceProduct : Product
    {
        decimal Value = 0;
        public override decimal ValueToPay()
        {
            return Value = Price * (decimal)Tax;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
