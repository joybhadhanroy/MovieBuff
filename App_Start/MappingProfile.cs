﻿using AutoMapper;
using MovieBuff.Dtos;
using MovieBuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBuff.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}