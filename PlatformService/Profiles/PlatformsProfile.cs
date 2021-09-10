using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
  public class PlatformsProfile : Profile
  {
    public PlatformsProfile()
    {
      // mappings - source -> target
      CreateMap<Platform, PlatformReadDto>();
      CreateMap<Platform, PlatformCreateDto>();
    }
  }
}