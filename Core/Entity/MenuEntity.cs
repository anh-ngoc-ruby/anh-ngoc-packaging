namespace anh_ngoc_packaging.Core.Entity
{
    public class MenuEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("type")]
        public string Type { get; set; } = string.Empty;

        [BsonElement("is_active")]
        public bool IsActive { get; set; } = true;

        [BsonElement("is_sub_menu")]
        public bool IsSubMenu { get; set; } = false;

        [BsonElement("priorty")]
        public int Priority { get; set; } 
    }
}
