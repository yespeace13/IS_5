using IS_5.Model;

namespace IS_5
{
    public class Localityprice
    {
        public int Id { get; set; }
        public Locality Locality { get; set; }
        public decimal Price { get; set; }
        public Localityprice(int id, Locality locality, decimal price)
        {
            Id = id;
            Locality = locality;
            Price = price;
        }
    }
}