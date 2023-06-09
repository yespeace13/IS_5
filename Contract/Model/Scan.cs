namespace IS_5
{
    public class Scan
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public Scan(int id, string path)
        {
            Id = id;
            Path = path;
        }
    }
}