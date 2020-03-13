﻿using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(string firstName, string lastName, string emailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress
            };

            string sql = @"insert into dbo.Employee (FirstName, LastName, EmailAddress)
                        values (@FirstName, @Lastname, @EmailAddress);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, FirstName, LastName, EmailAddress
                            from dbo.Employee;";
            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }


    }
}
