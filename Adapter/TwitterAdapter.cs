namespace DesignPatternsLab4.Adapter
{
    public class TwitterAPI
    {
        public void Tweet(string text) => Console.WriteLine($"Twitter: {text}");
    }

    public class TwitterAdapter : ISocialMediaAPI
    {
        private TwitterAPI tw = new TwitterAPI();
        public void PostMessage(string message) => tw.Tweet(message);
    }
}
