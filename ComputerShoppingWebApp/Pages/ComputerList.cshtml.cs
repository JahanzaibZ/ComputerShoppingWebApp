using ComputerShoppingWebApp.Models;
using ComputerShoppingWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ComputerShoppingWebApp.Pages
{
    public class ComputerListModel : PageModel
    {
        public IEnumerable<Computer> computers { get; private set; }
        public JsonFileComputerService computerService;
        public ComputerListModel(JsonFileComputerService computerService)
        {
            this.computerService = computerService;
        }
        public void OnGet()
        {
            computers = computerService.getComputersRecord();
        }
    }
}
