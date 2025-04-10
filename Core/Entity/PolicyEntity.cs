namespace anh_ngoc_packaging.Core.Entity
{
    public class PolicyEntity
    {
        [BsonId]
        [BsonElement("_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("title")]
        public string Title { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("image")]
        public string Image { get; set; } = string.Empty;

        [BsonElement("priority")]
        public int Priority { get; set; }

        [BsonElement("is_active")]
        public bool IsActive { get; set; } = true;
    }
}
