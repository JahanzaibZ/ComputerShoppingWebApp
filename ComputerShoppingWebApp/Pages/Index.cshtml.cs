using ComputerShoppingWebApp.Models;
using ComputerShoppingWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerShoppingWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Computer> computers { get; private set; }
        public JsonFileComputerService computerService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, JsonFileComputerService computerService)
        {
            _logger = logger;
            this.computerService = computerService;
        }

        public void OnGet()
        {
            computers = computerService.getComputersRecord();
        }
    }
}
