using AutoMapper;
using Dapper.Portfolio.Application.Dtos;
using Dapper.Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Portfolio.Application.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Skill, SkillDto>().ReverseMap();
            CreateMap<Info, InfoDto>().ReverseMap();
            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<Testimonial, TestimonialDto>().ReverseMap();
        }
    }
}
