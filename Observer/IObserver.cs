namespace DesignPatternsLab4.Observer
{
    public interface IObserver
    {
        void Update(string stockName, double price);
    }
}
