namespace DesignPatternsLab4.Adapter
{
    public class InstagramAPI
    {
        public void ShareStory(string caption) => Console.WriteLine($"Instagram: {caption}");
    }

    public class InstagramAdapter : ISocialMediaAPI
    {
        private InstagramAPI insta = new InstagramAPI();
        public void PostMessage(string message) => insta.ShareStory(message);
    }
}
