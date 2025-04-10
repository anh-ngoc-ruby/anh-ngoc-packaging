
namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetListMenuUseCase : IGetListMenuUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<MenuEntity> menuCollection;
        public GetListMenuUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.menuCollection = context.Menu;
        }
        public async Task<ListMenuResponseDto> Execute()
        {
            var dataReturnException = new ListMenuResponseDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var menus = await this.menuCollection
                  .Find(x => x.IsActive == true)
                  .ToListAsync();

                var dataReturn = new ListMenuResponseDto
                {
                    Items = this.mapper.Map<List<ItemListMenuResponseDto>>(menus),
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
