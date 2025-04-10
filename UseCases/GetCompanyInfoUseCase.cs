using MongoDB.Driver;

namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetCompanyInfoUseCase : IGetCompanyInfoUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<CompanyInfoEntity> companyCollection;
        public GetCompanyInfoUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.companyCollection = context.CompanyInfo;
        }
        public async Task<CompanyInfoResponseDto> Execute()
        {
            var dataReturnException = new CompanyInfoResponseDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var companyDocument = await this.companyCollection.Find(_ => true)
                    .Project(c => new
                    {
                        c.Id,
                        c.Name,
                        c.NameBrand,
                        c.Contacts,
                        c.SocialMedia,
                        c.Images
                    }).FirstOrDefaultAsync();

                var companyDto = new CompanyInfoResponseDto
                {
                    Id = companyDocument.Id,
                    Name = companyDocument.Name,
                    NameBrand = companyDocument.NameBrand,
                    Contacts = this.mapper.Map<CompanyContactResponseDto>(companyDocument.Contacts),
                    SocialMedia = this.mapper.Map<SocialMediaResponseDto>(companyDocument.SocialMedia),
                    Images = this.mapper.Map<ImagesCompanyResponseDto>(companyDocument.Images)
                };

                return companyDto;
            }
            catch (Exception ex)
            {
                dataReturnException.Errors.Add(new ErrorResponseDto
                {
                    Code = ex.GetType().Name,
                    Error = ex.Message
                });
            }
            return dataReturnException;
        }
    }
}
