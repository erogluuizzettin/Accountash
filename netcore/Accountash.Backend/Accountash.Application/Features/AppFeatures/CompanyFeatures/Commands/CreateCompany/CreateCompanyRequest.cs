using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateCompanyRequest : IRequest<CreateCompanyResponse>
    {
        public string Name { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DbUserId { get; set; }
        public string DbPassword { get; set; }
    }
}
