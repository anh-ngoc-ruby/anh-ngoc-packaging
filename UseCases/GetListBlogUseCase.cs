
namespace anh_ngoc_packaging.UseCases
{
    [ScopedService]
    public class GetListBlogUseCase : IGetListBlogUseCase
    {
        private readonly IMapper mapper;
        private readonly IMongoCollection<BlogEntity> blogCollection;
        public GetListBlogUseCase(IMapper mapper, MongoDbContext context)
        {
            this.mapper = mapper;
            this.blogCollection = context.Blog;
        }
        public async Task<ListBlogResponseDto> Execute(GetListBlogRequestDto param)
        {
            var dataReturnException = new ListBlogResponseDto { Errors = new List<ErrorResponseDto>() };
            try
            {
                var blogs = await this.blogCollection
                  .Find(x=> x.IsShow == true)
                  .Project(banner => new ItemListBlogResponseDto
                  {
                      Id = banner.Id,
                      Slug = banner.Slug,
                      CreatedAt = banner.CreatedAt,
                      Title = banner.Title,
                      Image = banner.Image
                  })
                  .ToListAsync();

                var dataReturn = new ListBlogResponseDto
                {
                    Items = blogs,
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
