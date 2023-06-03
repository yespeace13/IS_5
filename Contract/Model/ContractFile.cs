namespace IS_5
{
    public class ContractFile
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public ContractFile(int id, string path)
        {
            Id = id;
            Path = path;
        }
    }
}