using AutoMapper;
using AutoMapper.Configuration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MapperService<Src,Dest>
    {
        public static Mapper GetMapper()
        {
            var confige = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Src, Dest>();
            });

            var mapper = new Mapper(confige);
            return mapper;
        }

    }
}
