using ComputerShoppingWebApp.Models;
using ComputerShoppingWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ComputerShoppingWebApp.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {
        JsonFileComputerService computerService;
        public FormHandlerController(JsonFileComputerService computerService)
        {
            this.computerService = computerService;
        }
        [HttpGet]
        public string Get(int id, string brand, string model, string category, string price, string url)
        {
            Computer obj = new Computer();
            obj.computerId = id;
            obj.computerBrand = brand;
            obj.computerModel = model;
            obj.computerCategory = category;
            obj.computerPrice = price;
            obj.computerImage = url;

            IEnumerable<Computer> computersData = computerService.getComputersRecord();
            List<Computer> computersList = computersData.ToList();
            computersList.Add(obj);

            return JsonSerializer.Serialize<List<Computer>>(computersList);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
