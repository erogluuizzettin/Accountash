using Accountash.Domain.Abstraction;
using Accountash.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountash.Domain.AppEntities
{
    public class UserCompany : BaseEntity
    {
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
