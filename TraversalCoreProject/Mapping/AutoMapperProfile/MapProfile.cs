﻿using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.CityDTOs;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProject.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            //CreateMap<AnnouncementAddDto, Announcement>().ReverseMap(); 
            CreateMap<AnnouncementAddDto, Announcement>();
            CreateMap<Announcement,AnnouncementAddDto>();

            CreateMap<AnnouncementListDto, Announcement>().ReverseMap();
            CreateMap<AnnouncementUpdateDto, Announcement>().ReverseMap();

            CreateMap<AppUserRegisterDto, AppUser>();
            CreateMap<AppUser,AppUserRegisterDto>();

            CreateMap<AppUserLoginDto, AppUser>();
            CreateMap<AppUser, AppUserLoginDto>();

            CreateMap<SendMessageDto, ContactUs>().ReverseMap();

        }
    }
}
