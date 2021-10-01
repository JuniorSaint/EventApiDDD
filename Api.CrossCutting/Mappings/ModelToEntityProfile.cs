using System;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<EventEntity, EventModel>().ReverseMap();
            CreateMap<LotEntity, LotModel>().ReverseMap();
            CreateMap<SocialMediaEntity, SocialMediaModel>().ReverseMap();
            CreateMap<SpeakerEntity, SpeakerModel>().ReverseMap();
            CreateMap<UserEntity, UserModel>().ReverseMap();
        }
    }
}

