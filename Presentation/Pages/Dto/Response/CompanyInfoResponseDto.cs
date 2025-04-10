namespace anh_ngoc_packaging.Presentation.Pages.Dto.Response
{
    public class CompanyInfoResponseDto : BaseResponseDto
    {
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string NameBrand { get; set; } = string.Empty;

        public CompanyContactResponseDto Contacts { get; set; } = new CompanyContactResponseDto();

        public SocialMediaResponseDto SocialMedia { get; set; } = new SocialMediaResponseDto();
        public ImagesCompanyResponseDto Images { get; set; } = new ImagesCompanyResponseDto();
        public CompanyIntroducesResponseDto Introduces { get; set; } = new CompanyIntroducesResponseDto();
    }

    public class CompanyIntroducesResponseDto
    {
        public string Introduce1 { get; set; } = string.Empty;
        public string Introduce2 { get; set; } = string.Empty;
        public string IntroduceImage { get; set; } = string.Empty;
    }


    public class ImagesCompanyResponseDto
    {
        public string PrimaryLogo { get; set; } = string.Empty;
        public string SecondaryLogo { get; set; } = string.Empty;
        public string Favicon { get; set; } = string.Empty;
    }

    public class CompanyContactResponseDto
    {
        public string Address { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Fax { get; set; } = string.Empty;

        public string Hotline { get; set; } = string.Empty;
        public string OpeningHourWorking { get; set; } = string.Empty;
    }

    public class SocialMediaResponseDto
    {
        public string Facebook { get; set; } = string.Empty;

        public string YouTube { get; set; } = string.Empty;

        public string LinkedIn { get; set; } = string.Empty;

        public string TikTok { get; set; } = string.Empty;
    }
}
