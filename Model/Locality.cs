namespace IS_5.Model
{
    public class Locality
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public Locality(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}