using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCore.Logica.Models.DB
{
    public class Projects //: DAL.Models.Projects
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime? ExpectedCompletationDate { get; set; }
        public int? TenantId { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public Tenants Tenant { get; set; }
    }
}
