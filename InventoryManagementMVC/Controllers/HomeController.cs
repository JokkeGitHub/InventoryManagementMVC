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

        List<Item> itemList = new List<Item>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            connection.ConnectionString = Properties.Resources.ConnectionString;
        }

        public IActionResult Index()
        {
            FetchData();
            return View(itemList);
        }

        private void FetchData()
        {
            if (itemList.Count > 0)
            {
                itemList.Clear();
            }
            try
            {
                connection.Open();
                command.Connection = connection;

                // v + Where User = User
                command.CommandText = "SELECT [User], [Section], [Row], [Drawer], [Room], [Product], [Amount], [Type], [Supplier], [SupplierNumber], [Description] FROM Inventory ";
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader["User"].ToString() == User.Identity.Name)
                    {
                        itemList.Add(new Item(
                            dataReader["User"].ToString(),
                            dataReader["Section"].ToString(),
                            dataReader["Row"].ToString(),
                            dataReader["Drawer"].ToString(),
                            dataReader["Room"].ToString(),
                            dataReader["Product"].ToString(),
                            int.Parse(dataReader["Amount"].ToString()),
                            dataReader["Type"].ToString(),
                            dataReader["Supplier"].ToString(),
                            dataReader["SupplierNumber"].ToString(),
                            dataReader["Description"].ToString()));
                    }
                }
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
