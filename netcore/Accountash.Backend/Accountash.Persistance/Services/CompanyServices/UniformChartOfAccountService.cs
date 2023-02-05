using Accountash.Application.Features.CompanyFeatures.UniformChartOfAccountFeatures.Commands.CreateUniformChartOfAccount;
using Accountash.Application.Services.CompanyServices;
using Accountash.Domain;
using Accountash.Domain.CompanyEntities;
using Accountash.Domain.Repositories.UniformChartOfAccountRepository;
using Accountash.Persistance.Context;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Persistance.Services.CompanyServices
{
    public class UniformChartOfAccountService : IUniformChartOfAccountService
    {
        private readonly IUniformChartOfAccountCommandRepository _uniformChartOfAccountCommandRepository;
        private readonly IContextService _contextService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public UniformChartOfAccountService(IUniformChartOfAccountCommandRepository uniformChartOfAccountCommandRepository, IContextService contextService = null, IUnitOfWork unitOfWork = null, IMapper mapper = null)
        {
            _uniformChartOfAccountCommandRepository = uniformChartOfAccountCommandRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateUniformChartOfAccountAsync(CreateUniformChartOfAccountRequest request)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _uniformChartOfAccountCommandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);

            UniformChartOfAccount uniformChartOfAccount = _mapper.Map<UniformChartOfAccount>(request);
            uniformChartOfAccount.Id = Guid.NewGuid().ToString();
            await _uniformChartOfAccountCommandRepository.AddAsync(uniformChartOfAccount);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
