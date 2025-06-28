namespace DesignPatternsLab4.Singleton
{
    public class DatabaseConnection
    {
        private static DatabaseConnection? _instance;
        private static readonly object _lock = new object();

        private DatabaseConnection()
        {
            Console.WriteLine("Connected to DB");
        }

        public static DatabaseConnection GetInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new DatabaseConnection();
            }
            return _instance;       
        }
    }
}