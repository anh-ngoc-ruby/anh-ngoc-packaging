namespace anh_ngoc_packaging.Core.Entity
{
    public class ProductEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("slug")]
        public string Slug { get; set; } = string.Empty;

        [BsonElement("product_category_ids")]
        [BsonRepresentation(BsonType.ObjectId)]
        public List<string> ProductCategoryIds { get; set; } = new List<string>();

        [BsonElement("price")]
        public string Price { get; set; } = string.Empty;

        [BsonElement("final_price")]
        public string FinalPrice { get; set; } = string.Empty;

        [BsonElement("image")]
        public string Image { get; set; } = string.Empty;

        [BsonElement("images")]
        public List<string> Images { get; set; } =new  List<string>();

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("extra")]
        public Dictionary<string, object>? Extra { get; set; } = new Dictionary<string, object>();
    }
}
