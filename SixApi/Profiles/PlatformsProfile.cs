using AutoMapper;
using SixApi.Dtos;
using SixApi.Models;

namespace SixAPI.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target

            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}