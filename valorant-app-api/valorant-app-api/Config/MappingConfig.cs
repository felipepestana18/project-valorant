using AutoMapper;
using valorant_app_api.Data.ValueObject;

namespace valorant_app_api.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<CharacterVO, Model.Character>().ReverseMap();
                config.CreateMap<MapVO, Model.Map>().ReverseMap();
                config.CreateMap<MatchVO, Model.Match>().ReverseMap();
                config.CreateMap<MatchReturnVO, Model.Match>();


            });
            return mappingConfig;
        }
    }
}
