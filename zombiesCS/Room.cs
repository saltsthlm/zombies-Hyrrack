namespace zombiesCS
{
    public class Room
    {
        public int Capacity { get; private set; }
        public Room(int capacity)
        {
            this.Capacity = capacity;
        }


        public bool IsFull()
        {
            if (this.Capacity == 0)
            {
                return true;
            }
            return false;
        }
    }
}
