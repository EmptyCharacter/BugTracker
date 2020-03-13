using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class TicketModel
    {
        public string Title { get; set; }
        public string ProjectName { get; set; }
        public string DevAssigned { get; set; }
        public string TicketPriority { get; set; }
        public string TicketStatus { get; set; }
        public string TicketType { get; set; }
        public string TicketComments { get; set; }
        public DateTime Created { get; set; }
    }
}
