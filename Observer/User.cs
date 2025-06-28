namespace DesignPatternsLab4.Observer
{
    public class User : IObserver
    {
        public string Name { get; }

        public User(string name) => Name = name;

        public void Update(string stockName, double price)
        {
            Console.WriteLine($"[{Name}] Stock '{stockName}' changed to {price}$");
        }
    }
}
