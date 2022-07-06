using AutoMapper;
using AutoMapper.EquivalencyExpression;

namespace StoreStockControlTool.Controllers.Mapping
{
    public class AutoMapperConfiguration
    {
        public static IMapper Configure()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddCollectionMappers();
                cfg.AddProfile<DomainToViewModelMappingProfile>();
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}