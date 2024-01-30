﻿using AutoMapper;

namespace NotWorking
{
    public class GuidMappingProfile : Profile
    {
        public GuidMappingProfile()
        {
            CreateMap<Guid, IDestinationInterface>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src));
        }
    }
}
