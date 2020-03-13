using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using DataLibrary;
using static DataLibrary.BusinessLogic.EmployeeProcessor;
using static DataLibrary.BusinessLogic.ProjectProcessor;
using static DataLibrary.BusinessLogic.TicketProcessor;

namespace WebApplication1.Controllers
{
    public class DashboardController : Controller
    {
        //returns view of dashboard html file
        public ActionResult Dashboard()
        {
            return View();
        }


       


        public ActionResult Register()
        {
            ViewBag.Message = "Employee register";
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateEmployee(model.FirstName,
                    model.LastName,
                    model.EmailAddress);
                return RedirectToAction("Dashboard");
            }
            
            return View();
        }

        public ActionResult ViewEmployees()
        {
            ViewBag.Messaage = "List of Employees";
            var data = LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress


                });
            }

            return View(employees);
        }


        public ActionResult Project()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Project(ProjectModel model)
        {
            if (ModelState.IsValid)
            {
                int projectsCreated = CreateProject(model.ProjectName,
                    model.Description);
                return RedirectToAction("Dashboard");
            }

            return View();
        }


        public ActionResult ViewProjects()
        {
            ViewBag.Messaage = "List of Employees";
            var data = LoadProjects();
            List<ProjectModel> projects = new List<ProjectModel>();

            foreach (var row in data)
            {
                projects.Add(new ProjectModel
                {
                    ProjectName = row.ProjectName,
                    Description = row.Description
                    
                });
            }

            return View(projects);
        }


        public ActionResult Ticket()
        {


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ticket(TicketModel model)
        {
            if (ModelState.IsValid)
            {
                int ticketsCreated = CreateTicket(model.Title,
                    model.ProjectName,
                    model.DevAssigned,
                    model.TicketPriority,
                    model.TicketStatus,
                    model.TicketType,
                    model.TicketComments,
                    model.Created);

                return RedirectToAction("Dashboard");
            }

            return View();
        }


        public ActionResult ViewTickets()
        {
            ViewBag.Messaage = "List of Tickets";
            var data = LoadTickets();
            List<TicketModel> tickets = new List<TicketModel>();

            foreach (var row in data)
            {
                tickets.Add(new TicketModel
                {
                    Title = row.Title,
                    ProjectName = row.ProjectName,
                    DevAssigned = row.DevAssigned,
                    TicketPriority = row.TicketPriority,
                    TicketStatus = row.TicketStatus,
                    TicketType = row.TicketType,
                    TicketComments = row.TicketComments,
                    Created = row.Created


                });
            }

            return View(tickets);
        }







        public ActionResult Login()
        {
            return View();
        }






        



    }
}