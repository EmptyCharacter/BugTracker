using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class TicketProcessor
    {
        public static int CreateTicket(string title, string projectName, string devAssigned, string ticketPriority,
                                        string ticketStatus, string ticketType, string ticketComments, DateTime created)
        {
            TicketModel data = new TicketModel
            {
                Title = title,
                ProjectName = projectName,
                DevAssigned = devAssigned,
                TicketPriority = ticketPriority,
                TicketStatus = ticketPriority,
                TicketType = ticketType,
                TicketComments = ticketComments,
                Created = created
            };

            string sql = @"insert into dbo.Ticket (Title, ProjectName, DevAssigned, TicketPriority, TicketStatus, TicketType, TicketComments, Created)
                        values (@Title, @ProjectName, @DevAssigned, @TicketPriority, @TicketStatus, @TicketType, @TicketComments, @Created);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<TicketModel> LoadTickets()
        {
            string sql = @"select Id, Title, ProjectName, DevASsigned, TicketPriority, TicketStatus, TicketType, TicketComments, Created
                            from dbo.Ticket;";
            return SqlDataAccess.LoadData<TicketModel>(sql);
        }



    }
}
