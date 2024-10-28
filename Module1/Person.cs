namespace Module1
{
    public abstract class Person : Talkable
    {
        public string Name { get; set; }

        protected Person(string name)
        {
            Name = name;
        }

        public abstract string Talk();
    }
}