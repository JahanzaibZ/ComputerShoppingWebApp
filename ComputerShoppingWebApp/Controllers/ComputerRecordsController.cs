using ComputerShoppingWebApp.Models;
using ComputerShoppingWebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ComputerShoppingWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ComputerRecordsController : ControllerBase
    {
        JsonFileComputerService computerService;
        public ComputerRecordsController(JsonFileComputerService computerService)
        {
            this.computerService = computerService;
        }
        [HttpGet]
        public IEnumerable<Computer> Get()
        {
            return computerService.getComputersRecord();
        }
    }
}
