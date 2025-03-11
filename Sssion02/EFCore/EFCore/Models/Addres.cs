using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models
{
    [Owned]
    internal class Addres
    {
        
        public String? City { get; set; }
        public String? Country { get; set; }
        public String? Streat { get; set; }

    }
}
