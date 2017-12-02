using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Test.Models
{
    public class Input
    {
        [Required]
        public string Data { get; set; }
        [Required]
        public string DataType { get; set; }
        
 

     


    }
}
