using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _3.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
       
        public string Name { get; set; }

        public int Number { get; set; }

        
    }
}