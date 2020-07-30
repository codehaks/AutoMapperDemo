using AutoMapper;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Common
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<string, string>().ConvertUsing(new NoSpaces());
            CreateMap<Book, BookViewModel>();
        }
    }
}
