using DesignPatternsLab4.Singleton;
using DesignPatternsLab4.Adapter;
using DesignPatternsLab4.Observer;

namespace DesignPatternsLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var db1 = DatabaseConnection.GetInstance();
            var db2 = DatabaseConnection.GetInstance();

            List<ISocialMediaAPI> apis = new List<ISocialMediaAPI>
            {
                new FacebookAdapter(),
                new TwitterAdapter(),
                new InstagramAdapter()
            };

            foreach (var api in apis)
                api.PostMessage("Новини: акції компанії X зросли!");

            var stock = new Stock("AAPL", 150.0);
            var user1 = new User("Іван");
            var user2 = new User("Марія");

            stock.Subscribe(user1);
            stock.Subscribe(user2);
            stock.SetPrice(153.2);
        }
    }
}
