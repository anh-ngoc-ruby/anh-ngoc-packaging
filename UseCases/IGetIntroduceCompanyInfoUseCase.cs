namespace anh_ngoc_packaging.UseCases
{
    public interface IGetIntroduceCompanyInfoUseCase
    {
        Task<CompanyInfoResponseDto> Execute();
    }
}
