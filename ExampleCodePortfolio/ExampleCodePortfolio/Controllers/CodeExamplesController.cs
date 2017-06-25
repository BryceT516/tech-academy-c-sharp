using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExampleCodePortfolio.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Http;


namespace ExampleCodePortfolio.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CodeExamplesController : Controller
    {
        private readonly ExamplesContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public CodeExamplesController(ExamplesContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;

            if (_context.CodeExamples.Count() == 0)
            {
                _context.CodeExamples.Add(new CodeExample { Title = "Code Example 1", Description="Description 1...", Id=1, ImageUrl="image url 1", Url="url 1" });
                _context.SaveChanges();
            }

        }

        [HttpGet]
        public IEnumerable<CodeExample> GetAll()
        {
            return _context.CodeExamples.ToList();
        }

        [HttpGet]
        public IEnumerable<string> GetFilenames()
        {
            string[] imagesFilenamesList = Directory.GetFiles(_hostingEnvironment.WebRootPath + "\\images", "*.*",
                                         SearchOption.TopDirectoryOnly);

            return imagesFilenamesList;
        }

        [HttpGet("{id}", Name = "GetExample")]
        public IActionResult GetById(long id)
        {
            var item = _context.CodeExamples.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }


        [HttpPost]
        public IActionResult Create([FromBody] CodeExample item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            item.Id = 0;

            _context.CodeExamples.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetExample", new { id = item.Id }, item);
        }

        

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] CodeExample item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var codeExample = _context.CodeExamples.FirstOrDefault(t => t.Id == id);
            if (codeExample == null)
            {
                return NotFound();
            }

            codeExample.Title = item.Title;
            codeExample.Description = item.Description;
            codeExample.Url = item.Url;
            codeExample.ImageUrl = item.ImageUrl;

            _context.CodeExamples.Update(codeExample);
            _context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var codeExample = _context.CodeExamples.First(t => t.Id == id);
            if (codeExample == null)
            {
                return NotFound();
            }

            _context.CodeExamples.Remove(codeExample);
            _context.SaveChanges();
            return new NoContentResult();
        }



    }
}
