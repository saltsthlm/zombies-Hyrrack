namespace zombiesCS
{
    public class Room
    {
        public int Capacity { get; private set; }
        public Room(int capacity)
        {
            this.Capacity = capacity;
        }
    }
}
