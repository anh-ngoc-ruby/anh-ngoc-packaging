namespace anh_ngoc_packaging.Core.Entity
{
    public class ProductCategoryEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("slug")]
        public string Slug { get; set; } = string.Empty;

        [BsonElement("image")]
        public string Image { get; set; } = string.Empty;

        [BsonElement("priority")]
        public int Priority { get; set; } 

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("background")]
        public string Background { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("is_active")]
        public bool IsActive { get; set; } = true;

        [BsonElement("is_sub_menu")]
        public bool IsSubMenu { get; set; } = false;

        [BsonElement("is_banner")]
        public bool IsBanner { get; set; } = false;
    }
}
