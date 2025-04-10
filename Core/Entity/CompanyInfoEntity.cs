namespace anh_ngoc_packaging.Core.Entity
{
    public class CompanyInfoEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("name_brand")]
        public string NameBrand { get; set; } = string.Empty;

        [BsonElement("contacts")]
        public CompanyContactModel Contacts { get; set; } = new CompanyContactModel();

        [BsonElement("social_media")]
        public SocialMediaModel SocialMedia { get; set; } = new SocialMediaModel();

        [BsonElement("images")]
        public ImagesCompanyModel Images { get; set; } = new ImagesCompanyModel();

        [BsonElement("introduces")]
        public CompanyIntroduceModel Introduces { get; set; } = new CompanyIntroduceModel();
    }

    public class ImagesCompanyModel
    {
        [BsonElement("primary_logo")]
        public string PrimaryLogo { get; set; } = string.Empty;

        [BsonElement("secondary_logo")]
        public string SecondaryLogo { get; set; } = string.Empty;

        [BsonElement("favicon")]
        public string Favicon { get; set; } = string.Empty;
    }
    public class CompanyIntroduceModel
    {
        [BsonElement("introduce_1")]
        public string Introduce1 { get; set; } = string.Empty;

        [BsonElement("introduce_2")]
        public string Introduce2 { get; set; } = string.Empty;

        [BsonElement("introduce_image")]
        public string IntroduceImage { get; set; } = string.Empty;
    }

    public class CompanyContactModel
    {
        [BsonElement("address")]
        public string Address { get; set; } = string.Empty;

        [BsonElement("phone")]
        public string Phone { get; set; } = string.Empty;

        [BsonElement("email")]
        public string Email { get; set; } = string.Empty;

        [BsonElement("fax")]
        public string Fax { get; set; } = string.Empty;

        [BsonElement("hotline")]
        public string Hotline { get; set; } = string.Empty;
        [BsonElement("opening_hour_working")]
        public string OpeningHourWorking { get; set; } = string.Empty;
    }

    public class SocialMediaModel
    {
        [BsonElement("facebook")]
        public string Facebook { get; set; } = string.Empty;

        [BsonElement("youtube")]
        public string YouTube { get; set; } = string.Empty;

        [BsonElement("linkedIn")]
        public string LinkedIn { get; set; } = string.Empty;

        [BsonElement("tiktok")]
        public string TikTok { get; set; } = string.Empty;
    }
}
