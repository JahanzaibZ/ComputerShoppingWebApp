using ComputerShoppingWebApp.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ComputerShoppingWebApp.Services
{
    public class JsonFileComputerService
    {
        public JsonFileComputerService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath,"data", "Computers.json");
            }
        }

        public IEnumerable<Computer> getComputersRecord()
        {
            using(var jsonFile = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Computer[]>(jsonFile.ReadToEnd());
            }
        }
    }
}
