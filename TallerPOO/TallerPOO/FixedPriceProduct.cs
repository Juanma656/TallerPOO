namespace TallerPOO
{
    public class FixedPriceProduct : Product
    {
        //decimal Value = 0;
        public override decimal ValueToPay()
        {
            return Price * (decimal)Tax + Price;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
