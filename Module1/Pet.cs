namespace Module1
{
    public abstract class Pet : Talkable
    {
        public string Name { get; protected set; }

        protected Pet(string name)
        {
            Name = name;
        }

        public abstract string Talk();
    }
}