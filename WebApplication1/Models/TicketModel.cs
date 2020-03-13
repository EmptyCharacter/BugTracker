using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TicketModel
    {
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Project Name")]

        public string ProjectName { get; set; }

        [Display(Name = "Dev Assigned")]
        public string DevAssigned { get; set; }

        [Display(Name = "Ticket Priority")]
        public string TicketPriority { get; set; }

        [Display(Name = "Ticket Status")]
        public string TicketStatus { get; set; }

        [Display(Name = "Ticket Type")]
        public string TicketType { get; set; }

        [Display(Name = "Ticket Comments")]
        public string TicketComments { get; set; }

        [Display(Name = "Created")]
        [DataType(DataType.Date)]
        public DateTime Created { get; set; }
    }
}