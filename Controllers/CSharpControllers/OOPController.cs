using itvidpradotnetcoreadvanced.Models.CSharpModels;
using itvidpradotnetcoreadvanced.Models.CSharpModels.Constants;
using itvidpradotnetcoreadvanced.Services.CSharpServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using itvidpradotnetcoreadvanced.Models.CSharpModels;
using itvidpradotnetcoreadvanced.Models.CSharpModels.Constants;
using itvidpradotnetcoreadvanced.Services.CSharpServices;
using Microsoft.AspNetCore.Mvc;
using itvidpradotnetcoreadvanced.Models;

namespace itvidpradotnetcoreadvanced.Controllers.CSharpControllers
{
    [Route("documents")]
    public class OOPController : Controller
    {
        private readonly IFileReaderService _fileReaderService;
        private readonly DataFilePath _dataFilePath;
        private readonly LoginContext _loginContext;

        public OOPController(IFileReaderService fileReaderService)
        {
            _fileReaderService = fileReaderService;
            _dataFilePath = new DataFilePath();
        }
        // GET: HomeController
        [HttpGet]
        [Route("DayTwo")]
        public ActionResult DataType()
        {
            DayTwo daytwo = new DayTwo()
            {
                Content = _fileReaderService.ReadContent(_dataFilePath.Day_2)
            };
            return View(daytwo);
        }

        [HttpGet]
        [Route("DayFour")]
        public ActionResult NameSpace()
        {
            DayFour dayfour = new DayFour()
            {
                Content = _fileReaderService.ReadContent(_dataFilePath.Day_4)
            };
            return View(dayfour);
        }

        [HttpGet]
        [Route("DaySeven")]
        public ActionResult DeleGate()
        {
            DaySeven dayseven = new DaySeven()
            {
                Content = _fileReaderService.ReadContent(_dataFilePath.Day_7)
            };
            return View(dayseven);
        }

        [HttpGet]
        [Route("DayTen")]
        public ActionResult Dictionary()
        {
            DayTen dayten = new DayTen()
            {
                Content = _fileReaderService.ReadContent(_dataFilePath.Day_10)
            };
            return View(dayten);
        }


    }
}