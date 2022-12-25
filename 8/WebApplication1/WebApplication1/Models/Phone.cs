using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace WebApplication1.Models
{

    public class Phone
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }
    }
}
