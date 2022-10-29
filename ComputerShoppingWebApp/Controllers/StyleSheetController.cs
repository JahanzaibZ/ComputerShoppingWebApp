using ComputerShoppingWebApp.Models;
using ComputerShoppingWebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ComputerShoppingWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StyleSheetController : ControllerBase
    {
        cssFileStyleSheetService styleSheetService;
        public StyleSheetController(cssFileStyleSheetService styleSheetService)
        {
            this.styleSheetService = styleSheetService;
        }
        [HttpGet]
        public string Get()
        {
            return styleSheetService.getStyleSheet();
        }
    }
}
