namespace anh_ngoc_packaging
{
    public static class AppConfig
    {
        public static ConfigurationManager Cfm = new ConfigurationManager();
        public static MongoConfig DatabaseConfig = new MongoConfig();
        public static void Init(ConfigurationManager cfm)
        {
            Cfm = cfm;
            DatabaseConfig = cfm.GetSection("MongoDatabase").Get<MongoConfig>()!;
        }

        public class MongoConfig
        {
            [JsonPropertyName("ConnectionString")]
            public string ConnectionString { get; set; } = string.Empty;

            [JsonPropertyName("DatabaseName")]
            public string DatabaseName { get; set; } = string.Empty;
        }
    }
}
