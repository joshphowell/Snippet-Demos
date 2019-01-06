using AutoMapper;

namespace SnippetDemos
{
    public class AutoMapperConfig
    {
        private static IMapper mapper;

        public static IMapper GetAutoMapper()
        {
            return mapper;
        }

        public static void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Add mappings here.

                // Mapping class to class with same properties, but put into a complex type property of the destination class
                //cfg.CreateMap<Source, DestinationComplexProperty>(MemberList.Destination);
                //cfg.CreateMap<Source, Destination>()
                //    .ForMember(dest => dest.ComplexProperty, opt => opt.MapFrom(s => s))

            });
                
            mapper = config.CreateMapper();

            // Check mappings are correct.
            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}