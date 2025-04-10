
using anh_ngoc_packaging.Core.Entity;

namespace anh_ngoc_packaging.Infrastructure.Extenstions
{
    public class AutoMapperProfileExtension : Profile
    {
        public AutoMapperProfileExtension()
        {
            CreateMap<CompanyInfoEntity, CompanyInfoResponseDto>();
            CreateMap<CompanyContactModel, CompanyContactResponseDto>();
            CreateMap<SocialMediaModel, SocialMediaResponseDto>();
            CreateMap<ProductCategoryEntity, ItemListProductCategoryBannerResponseDto>();
            CreateMap<ComponentEntity, ItemListComponentResponseDto>();
            CreateMap<ComponentConfigModel, ComponentConfigResponseDto>();
            CreateMap<ComponentContentModel, ComponentContentResponseDto>();
            CreateMap<MenuEntity, ItemListMenuResponseDto>();
            CreateMap<ImagesCompanyModel, ImagesCompanyResponseDto>();
            CreateMap<PolicyEntity, ItemListPolicyResponseDto>();
            CreateMap<CompanyIntroduceModel, CompanyIntroducesResponseDto>();
            CreateMap<ProductEntity, ProductDetailResponseDto>();
        }
    }
}
