namespace vezba_02.Costumer
{
    public class Custumer
    {
        public int Id;
        public string Name;

        public Custumer()
        {

        }
        public Custumer(int id)
        {
            Id = id;
        }
        public Custumer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
