using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
#region     add by AWR
using Microsoft.Extensions.Configuration;
#endregion 

namespace EFtoSQL.Controllers
{
    public class BlogController : Controller
    {

        #region     add by AWR

        private readonly IConfiguration configuration;
        private readonly string connectionString;


        public BlogController(IConfiguration config)
        {
            configuration = config;
            connectionString = configuration.GetConnectionString("DefaultConnection").Trim();
            if (connectionString == "")
            {
                throw new Exception("ConnectionString is empty in configuration file.");
            }
            // generating Model from EXISTING DB run in CMD *.cproj 
            // dotnet ef dbcontext scaffold "Data Source=192.168.168.110;Initial Catalog=Blogging;User ID=awr_qazwsx;Password=qazwsx;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer - o Models\Blog - c BlogEntities
        }

        #endregion 


        public IActionResult Index()
        {
            return View();
        }


    }
}