using Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Accountash.Domain.AppEntities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Persistance.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCompanyRequest, Company>().ReverseMap();
        }
    }
}
