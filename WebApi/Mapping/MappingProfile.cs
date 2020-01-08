using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Core.Models;
using WebApplication1.Dto;

namespace WebApplication1.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDto, Product>();
        }
    }
}
