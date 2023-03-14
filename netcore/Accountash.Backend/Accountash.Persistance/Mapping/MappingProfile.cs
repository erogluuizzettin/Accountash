using Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Accountash.Application.Features.CompanyFeatures.UniformChartOfAccountFeatures.Commands.CreateUniformChartOfAccount;
using Accountash.Domain.AppEntities;
using Accountash.Domain.AppEntities.Identity;
using Accountash.Domain.CompanyEntities;
using AutoMapper;

namespace Accountash.Persistance.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateCompanyCommand, Company>();
        CreateMap<CreateUniformChartOfAccountCommand, UniformChartOfAccount>();
        CreateMap<CreateRoleCommand, AppRole>();
    }
}
