

namespace anh_ngoc_packaging.Infrastructure.MongoDb
{
    [ScopedService]
    public class MongoDbContext
    {
        private readonly IMongoDatabase database;
        public MongoDbContext()
        {
            //get connectionString
            var connectionString = AppConfig.DatabaseConfig.ConnectionString;

            //get db name
            var databaseName = AppConfig.DatabaseConfig.DatabaseName;
            var mongoSettings = MongoClientSettings.FromConnectionString(connectionString);
            var client = new MongoClient(mongoSettings);
            database = client.GetDatabase(databaseName);
            CreateUniqueIndex();
        }
        public IMongoCollection<PolicyEntity> Policy => database.GetCollection<PolicyEntity>("policies");
        public IMongoCollection<ProductEntity> Product => database.GetCollection<ProductEntity>("products");
        public IMongoCollection<ProductCategoryEntity> ProductCategory => database.GetCollection<ProductCategoryEntity>("product_categories");
        public IMongoCollection<MenuEntity> Menu => database.GetCollection<MenuEntity>("menus");
        public IMongoCollection<CompanyInfoEntity> CompanyInfo => database.GetCollection<CompanyInfoEntity>("company_information");
        public IMongoCollection<CompanyContactModel> CompanyContact => database.GetCollection<CompanyContactModel>("company_contacts");
        public IMongoCollection<BlogEntity> Blog => database.GetCollection<BlogEntity>("blogs");
        public IMongoCollection<ComponentEntity> Component => database.GetCollection<ComponentEntity>("components");
        private void CreateUniqueIndex()
        {
            Product.Indexes.CreateMany(new List<CreateIndexModel<ProductEntity>> {
                new CreateIndexModel<ProductEntity>(Builders<ProductEntity>.IndexKeys.Ascending(u => u.Slug), new CreateIndexOptions { Unique = true }),
                new CreateIndexModel<ProductEntity>(Builders<ProductEntity>.IndexKeys.Text(u => u.Name), new CreateIndexOptions { DefaultLanguage = "none" }),
                new CreateIndexModel<ProductEntity>(Builders<ProductEntity>.IndexKeys.Ascending(u => u.ProductCategoryIds), new CreateIndexOptions {  }),
            });

            Blog.Indexes.CreateMany(new List<CreateIndexModel<BlogEntity>> {
                new CreateIndexModel<BlogEntity>(Builders<BlogEntity>.IndexKeys.Ascending(u => u.Slug), new CreateIndexOptions { Unique = true }),
                new CreateIndexModel<BlogEntity>(Builders<BlogEntity>.IndexKeys.Ascending(u => u.IsShow), new CreateIndexOptions {}),
            });

            Menu.Indexes.CreateMany(new List<CreateIndexModel<MenuEntity>> {
                new CreateIndexModel<MenuEntity>(Builders<MenuEntity>.IndexKeys.Ascending(u => u.IsSubMenu), new CreateIndexOptions {  }),
                new CreateIndexModel<MenuEntity>(Builders<MenuEntity>.IndexKeys.Ascending(u => u.IsActive), new CreateIndexOptions { }),
                new CreateIndexModel<MenuEntity>(Builders<MenuEntity>.IndexKeys.Text(u => u.Name), new CreateIndexOptions { DefaultLanguage = "none" }),
            });

            ProductCategory.Indexes.CreateMany(new List<CreateIndexModel<ProductCategoryEntity>> {
                new CreateIndexModel<ProductCategoryEntity>(Builders<ProductCategoryEntity>.IndexKeys.Ascending(u => u.Slug), new CreateIndexOptions { Unique = true }),
                new CreateIndexModel<ProductCategoryEntity>(Builders<ProductCategoryEntity>.IndexKeys.Text(u => u.Name), new CreateIndexOptions { DefaultLanguage = "none" }),
                         new CreateIndexModel<ProductCategoryEntity>(Builders<ProductCategoryEntity>.IndexKeys.Ascending(u => u.IsBanner), new CreateIndexOptions {  }),
                         new CreateIndexModel<ProductCategoryEntity>(Builders<ProductCategoryEntity>.IndexKeys.Ascending(u => u.IsSubMenu), new CreateIndexOptions {  }),
                         new CreateIndexModel<ProductCategoryEntity>(Builders<ProductCategoryEntity>.IndexKeys.Ascending(u => u.IsActive), new CreateIndexOptions {  }),
            });
        }

    }
}
