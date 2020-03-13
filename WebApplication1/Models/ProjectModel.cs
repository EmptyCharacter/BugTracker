using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProjectModel
    {
        [Display(Name ="Project Name")]
        public string ProjectName { get; set; }

        [Display(Name ="Description")]
        public string Description { get; set; }
    }
}