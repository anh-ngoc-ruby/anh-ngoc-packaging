namespace anh_ngoc_packaging.Shared.Dto.Request
{
    public class PagingRequestDto : BaseRequestDto
    {
        private int page = 1;
        public int Page
        {
            get => page;
            set => page = (value < 1) ? 1 : value;
        }

        private int pageSize = 10;
        public int PageSize
        {
            get => pageSize;
            set => pageSize = (value <= 0) ? 10 : (value > 100 ? 100 : value);
        }

        public int Skip => (Page - 1) * pageSize;

    }
}
