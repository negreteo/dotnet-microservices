using System;
using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
  public class PlatformsProfile : Profile
  {
    public PlatformsProfile()
    {
      // mappings: source (model) -> target (dto)
      CreateMap<Platform, PlatformReadDto>();
      // mappings: source (dto) -> target (model)
      CreateMap<PlatformCreateDto, Platform>();
    }
  }
}