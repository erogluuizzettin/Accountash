using Accountash.Domain.Abstraction;

namespace Accountash.Domain.AppEntities
{
    public sealed class Company : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string IdentityNumber { get; set; }
        public string TaxDepartment { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DbUserId { get; set; }
        public string DbPassword { get; set; }
    }
}
