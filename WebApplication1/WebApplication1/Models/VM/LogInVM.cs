using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.VM
{
#nullable enable
    public class LogInVM
    {
        public string? username{ get; set; }
        public string? password{ get; set; }
        public int? userId{ get; set; }
        public string? user{ get; set; }
        public int? roleId { get; set; }
        public string? role { get; set; }
        public int? organisationId { get; set; }
        public string? organisation { get; set; }
        public int? orgJedId { get; set; }
        public string? orgJed { get; set; }
    }
}