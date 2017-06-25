using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExampleCodePortfolio.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Http;

namespace ExampleCodePortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExamplesContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(ExamplesContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Admin()
        {
            return View(await _context.CodeExamples.ToListAsync());
        }


        [HttpPost]
        public IActionResult Admin(IList<IFormFile> files)
        {
            foreach (var file in files)
           {
                var fileName = ContentDispositionHeaderValue
                    .Parse(file.ContentDisposition)
                    .FileName
                    .Trim('"');// FileName returns "fileName.ext"(with double quotes) in beta 3
                string[] fileNameParts = fileName.Split('\\');
                var filePath = _hostingEnvironment.WebRootPath + $@"\images\{fileNameParts.Last()}";
                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }
            return RedirectToAction("Admin");// PRG
        }


        public IActionResult Error()
        {
            return View();
        }

    }
}