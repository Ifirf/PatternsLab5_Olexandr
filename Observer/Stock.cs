namespace DesignPatternsLab4.Observer
{
    public class Stock
    {
        private List<IObserver> observers = new List<IObserver>();
        private string _stockName;
        private double _price;

        public Stock(string name, double initialPrice)
        {
            _stockName = name;
            _price = initialPrice;
        }

        public void Subscribe(IObserver observer) => observers.Add(observer);
        public void Unsubscribe(IObserver observer) => observers.Remove(observer);

        public void SetPrice(double newPrice)
        {
            _price = newPrice;
            Notify();
        }

        private void Notify()
        {
            foreach (var obs in observers)
                obs.Update(_stockName, _price);
        }
    }
}
