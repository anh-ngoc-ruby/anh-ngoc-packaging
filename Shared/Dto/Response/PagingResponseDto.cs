namespace anh_ngoc_packaging.Shared.Dto.Response
{
    public class PagingResponseDto : BaseResponseDto
    {
        public int TotalCount { get; set; } = 0;

        public int TotalPage
        {
            get
            {
                return (this.TotalCount / this.PageSize);
            }
        }

        public int Page { get; set; } 

        public int PageSize { get; set; }

        public string Type { get; set; } = string.Empty;

    }
}
