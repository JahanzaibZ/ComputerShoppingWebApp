using ComputerShoppingWebApp.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Text.Json;

namespace ComputerShoppingWebApp.Services
{
    public class cssFileStyleSheetService
    {
        public cssFileStyleSheetService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public string cssFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "css", "StyleSheet.css");
            }
        }
        public string getStyleSheet()
        {
            using (var cssFile = File.OpenText(cssFilePath))
            {
                return cssFile.ReadToEnd();
            }
        }
    }
}
