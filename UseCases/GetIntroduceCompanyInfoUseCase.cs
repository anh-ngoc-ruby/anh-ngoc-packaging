
namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetIntroduceCompanyInfoUseCase : IGetIntroduceCompanyInfoUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<CompanyInfoEntity> companyCollection;
        public GetIntroduceCompanyInfoUseCase(IMapper mapper, MongoDbContext context)
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
                        c.Introduces
                    }).FirstOrDefaultAsync();

                var company = new CompanyInfoResponseDto
                {
                    Id = companyDocument.Id,
                    Name = companyDocument.Name,
                    NameBrand = companyDocument.NameBrand,
                    Introduces = this.mapper.Map<CompanyIntroducesResponseDto>(companyDocument.Introduces)
                };

                return company;
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
