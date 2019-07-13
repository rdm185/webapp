using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Dal
{
    public class dalEmployees
    {
        EmployeeContext _db = new EmployeeContext();


        public string Save()
        {

            var parParam = new SqlParameter("Date",System.DateTime.Now);

            _db.Database.SqlQuery<string>("SpName @Date",parParam).ToList();

            return "";
        }
    }
}