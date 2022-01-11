using AutoMapper;
using PatinsAPI.Dtos;
using PatinsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatinsAPI.Profiles
{
    public class PatinsProfile : Profile
    {
        public PatinsProfile()
        {
            CreateMap<PostPatinsDto, Patins>();
            CreateMap<PutPatinsDto, Patins>();
            CreateMap<Patins, GetPatinsByIdDto>();
        }
    }
}
