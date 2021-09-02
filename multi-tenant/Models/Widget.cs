using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace multi_tenant.Models
{
    public class Widget
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }
    }
}
