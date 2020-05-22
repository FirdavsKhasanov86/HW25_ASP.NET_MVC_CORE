using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HW25_ASP.NET_MVC_CORE.Models;
using System.Data.SqlClient;
using System.Data;
using Dapper;
namespace HW25_ASP.NET_MVC_CORE.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            var conString = "Data Source=localhost;Initial Catalog=AlifAcademy;Integrated Security=True";
            using (IDbConnection db = new SqlConnection(conString))
            {

                var personList = db.Query<Person>($"SELECT * FROM PERSON").ToList();
                return View(personList);
            }

        }

    }
}
