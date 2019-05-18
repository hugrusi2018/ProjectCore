using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCore.Logica.Models.DB
{
    public class Tenants
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string Plan { get; set; }
    }
}