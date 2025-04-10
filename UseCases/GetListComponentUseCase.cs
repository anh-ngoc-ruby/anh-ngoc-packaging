
namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetListComponentUseCase : IGetListComponentUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<ComponentEntity> componentCollection;
        public GetListComponentUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.componentCollection = context.Component;
        }
        public async Task<ListComponentResponseDto> Execute()
        {
            var dataReturnException = new ListComponentResponseDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var components = await this.componentCollection
                  .Find(x => x.IsActive == true)
                  .ToListAsync();

                var dataReturn = new ListComponentResponseDto
                {
                    Items = this.mapper.Map<List<ItemListComponentResponseDto>>(components),
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
