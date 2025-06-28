namespace DesignPatternsLab4.Adapter
{
    public class FacebookAPI
    {
        public void SendToWall(string text) => Console.WriteLine($"Facebook: {text}");
    }

    public class FacebookAdapter : ISocialMediaAPI
    {
        private FacebookAPI fb = new FacebookAPI();
        public void PostMessage(string message) => fb.SendToWall(message);
    }
}
