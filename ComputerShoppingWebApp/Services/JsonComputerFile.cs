using ComputerShoppingWebApp.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ComputerShoppingWebApp.Services
{
    public class JsonComputerFile
    {
        public JsonComputerFile(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath,"data","computers.json");
            }
        }

        public IEnumerable<Computer> getComputersData()
        {
            using(var jsonFile = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Computer[]>(jsonFile.ReadToEnd());
            }
        }
    }
}
