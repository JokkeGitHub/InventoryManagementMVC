using InventoryManagementMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManagementMVC.Controllers
{
    public class HomeController : Controller
    {
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        SqlConnection connection = new SqlConnection();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            connection.ConnectionString = Properties.Resources.ConnectionString;
        }

        public IActionResult Index()
        {
            return View();
        }

        private void FetchData()
        {
            try
            {
                connection.Open();
                command.Connection = connection;

                //+ Where User = User
                command.CommandText = "SELECT [Section], [Row], [Drawer], [Room], [Product], [Amount], [Type], [Supplier], [SupplierNumber], [Description] FROM Inventory";
                dataReader = command.ExecuteReader();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Jokke()
        {
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
