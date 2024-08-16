using itvidpradotnetcoreadvanced.Models.CSharpModels;
using itvidpradotnetcoreadvanced.Models.CSharpModels.Constants;
using itvidpradotnetcoreadvanced.Services.CSharpServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using itvidpradotnetcoreadvanced.Models.CSharpModels;
using itvidpradotnetcoreadvanced.Models.CSharpModels.Constants;
using itvidpradotnetcoreadvanced.Services.CSharpServices;
using Microsoft.AspNetCore.Mvc;

namespace itvidpradotnetcoreadvanced.Controllers.CSharpControllers
{
    [Route("oop")]
    public class OOPController : Controller
    {
        private readonly IFileReaderService _fileReaderService;
        private readonly DataFilePath _dataFilePath;
        public OOPController(IFileReaderService fileReaderService)
        {
            _fileReaderService = fileReaderService;
            _dataFilePath = new DataFilePath();
        }
        // GET: HomeController
        [HttpGet]
        [Route("DataType")]
        public ActionResult DataType()
        {
            Datatype datatype = new Datatype()
            {
                Content = _fileReaderService.ReadContent(_dataFilePath.DataType)
            };
            return View(datatype);
        }
    }
}