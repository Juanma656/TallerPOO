namespace TallerPOO
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal ValueToPay();


        public override string ToString()
        {
            return $"Description: {Description} " +
                $"\n\tId: {Id}, " +
                $"\n\tPrice: {Price}, " +
                $"\n\tTax: {Tax}"+
                $"\n\tValue .........: {$"{ValueToPay():C2}",18}";
        }

    }
}
