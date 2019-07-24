using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CMIM.Models
{
    public class Site
    {
   
     
            [Key]
            public long SiteId { get; set; }
            public string name { get; set; }
            public virtual ICollection<Company> Company { get; set; }
            public virtual ICollection<Employee> employee { get; set; }

    }
}
