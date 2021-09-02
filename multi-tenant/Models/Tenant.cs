using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace multi_tenant.Models
{
    public class Tenant
    {
        public string TenantId { get; set; }
        public string DatabaseServerName { get; set; }
        public string DatabaseName { get; set; }
    }
}
