
namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetListPolicyUseCase : IGetListPolicyUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<PolicyEntity> policyCollection;
        public GetListPolicyUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.policyCollection = context.Policy;
        }
        public async Task<ListPolicyResponseDto> Execute()
        {
            var dataReturnException = new ListPolicyResponseDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var menus = await this.policyCollection
                  .Find(x => x.IsActive == true)
                  .ToListAsync();

                var dataReturn = new ListPolicyResponseDto
                {
                    Items = this.mapper.Map<List<ItemListPolicyResponseDto>>(menus),
                };

                return dataReturn;
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
