namespace anh_ngoc_packaging.Core.Entity
{
    public class CompanyContactEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("title")]
        public string Title { get; set; } = string.Empty;

        [BsonElement("primary_phone")]
        public string PrimaryPhone { get; set; } = string.Empty;

        [BsonElement("secondary_phone")]
        public string SecondaryPhone { get; set; } = string.Empty;

        [BsonElement("primary_email")]
        public string PrimaryEmail { get; set; } = string.Empty;

        [BsonElement("secondary_email")]
        public string SecondaryEmail { get; set; } = string.Empty;
    }
}
