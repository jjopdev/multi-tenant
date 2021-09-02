using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace multi_tenant.Models
{
    public class TenantSettings
    {
        public string TenantId { get; set; }
        public string DefaultConnectionString { get; set; }
    }
}
