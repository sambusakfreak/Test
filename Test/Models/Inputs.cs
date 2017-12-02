using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Test.Models
{
    public class Inputs 
    {

        
        [Required]
        public List<string> Data { get; set; }

       

        [Required]
        public List<string> Datatype { get; set; }

        public Inputs()
        {
            Datatype = new List<string>();
            Data = new List<string>();
        }

        public List<SelectListItem> Types { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "ID_", Text = "ID" },
            new SelectListItem { Value = "FNAME_", Text = "First name" },
            new SelectListItem { Value = "LNAME_", Text = "Last name"  },
        };


    }
}
