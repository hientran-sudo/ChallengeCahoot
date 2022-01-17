using Challenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;

        //private ChallengeDbContext context { get; set; }

        //public HomeController(ChallengeDbContext ctx)
        //{
        //    context = ctx;
        //}

        public HomeController(IConfiguration config)
        {
            this.configuration = config;
        }

        public IActionResult Index(string search)
        {
            string connectionstring = configuration.GetConnectionString("Default");
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            //ViewData["Results"] = search;
            //var squery = from x in context.Posts select x;
            //squery = squery.Where(x => x.Body.Contains(search));


            SqlCommand com = new SqlCommand("Select Count(*) from LinkTypes", connection);
            var count = (int)com.ExecuteScalar();
            ViewData["TotalData"] = count;
            connection.Close();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
