using AutoMapper;

namespace Gamers8.Api.Configurations.Mapping
{
    public interface IMapFrom<T>
    {   
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
