using System;
using Api.Domain.Dtos.Event;
using Api.Domain.Dtos.Lot;
using Api.Domain.Dtos.SocialMedia;
using Api.Domain.Dtos.Speaker;
using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region User
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserCreateDto>().ReverseMap();
            CreateMap<UserModel, UserUpdateDto>().ReverseMap();
            CreateMap<UserModel, UserUpdateResultDto>().ReverseMap();
            #endregion

            #region Event
            CreateMap<EventModel, EventDto>().ReverseMap();
            CreateMap<EventModel, EventCreateDto>().ReverseMap();
            CreateMap<EventModel, EventUpdateDto>().ReverseMap();
            #endregion

            #region Lot
            CreateMap<LotModel, LotDto>().ReverseMap();
            CreateMap<LotModel, LotCreateDto>().ReverseMap();
            CreateMap<LotModel, LotUpdateDto>().ReverseMap();
            #endregion

            #region Speaker
            CreateMap<SpeakerModel, SpeakerDto>().ReverseMap();
            CreateMap<SpeakerModel, SpeakerCreateDto>().ReverseMap();
            CreateMap<SpeakerModel, SpeakerUpdateDto>().ReverseMap();
            #endregion

            #region SocialMedia
            CreateMap<SocialMediaModel, SocialMediaDto>().ReverseMap();
            CreateMap<SocialMediaModel, SocialMediaCreateDto>().ReverseMap();
            CreateMap<SocialMediaModel, SocialMediaUpdateDto>().ReverseMap();
            #endregion
        }
    }
}

