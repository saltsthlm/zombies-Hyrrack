namespace zombiesCS
{
    public class Room
    {
        public int Capacity { get; private set; }
        private Queue<string> _zombies = new Queue<string>();
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
            if (_zombies.Count >= this.Capacity)
            {
                return true;
            }
            return false;
        }

        public void AddZombie(string zombie)
        {
            if (this.Capacity < 1)
            {
                throw new Exception("Cannot add zombies to room with zero capacity");
            }

            _zombies.Enqueue(zombie);
        }

        public int GetZombies()
        {
            return _zombies.Count;
        }
    }
}
