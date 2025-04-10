namespace anh_ngoc_packaging.Core.Entity
{
    public class ComponentEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("file_name")]
        public string FileName { get; set; } = string.Empty;

        [BsonElement("config")]
        public ComponentConfigModel Config { get; set; } = new ComponentConfigModel();

        [BsonElement("content")]
        public ComponentContentModel Content { get; set; } = new ComponentContentModel();

        [BsonElement("is_active")]
        public bool IsActive { get; set; } = true;

        [BsonElement("priorty")]
        public int Priority { get; set; }

        [BsonElement("extra")]
        public Dictionary<string, object>? Extra { get; set; } = new Dictionary<string, object>();
    }

    public class ComponentConfigModel
    {
        [BsonElement("title_color")]
        public string TitleColor { get; set; } = string.Empty;

        [BsonElement("sub_title_color")]
        public string SubTitleColor { get; set; } = string.Empty;

        [BsonElement("description_color")]
        public string DescriptionColor { get; set; } = string.Empty;

        [BsonElement("background_color")]
        public string BackgroundColor { get; set; } = string.Empty;

        [BsonElement("button_background")]
        public string ButtonBackground { get; set; } = string.Empty;

        [BsonElement("button_text_color")]
        public string ButtonTextColor { get; set; } = string.Empty;
    }

    public class ComponentContentModel
    {
        [BsonElement("title")]
        public string Title { get; set; } = string.Empty;

        [BsonElement("url")]
        public string Url { get; set; } = string.Empty;

        [BsonElement("description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("background")]
        public string Background { get; set; } = string.Empty;

        [BsonElement("button")]
        public string Button { get; set; } = string.Empty;

        [BsonElement("button_text")]
        public string ButtonText { get; set; } = string.Empty;

        [BsonElement("sub_title")]
        public string SubTitle { get; set; } = string.Empty;
    }
}
