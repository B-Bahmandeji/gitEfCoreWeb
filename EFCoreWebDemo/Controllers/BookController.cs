using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreWebDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCoreWebDemo.Controllers
{
    public class BookController : Controller
    {
        private readonly EFCoreWebDemoContext context;

        public BookController(EFCoreWebDemoContext context)
        {
            this.context = context;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            //dbcontext instantiated in using block to be sure is disposed properly
            using(context )
            {
                var model = await context.Authors.Include(a=>a.Books).AsNoTracking().ToListAsync();//noTracking useful when result use in readonly, no need to change
                return View(model);
            }
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var authors = await context.Authors.Select(a => new SelectListItem
            {
                Value = a.AuthorId.ToString(),
                Text = $"{a.FirstName} {a.LastName}"
            }).ToListAsync();
            ViewBag.Authors = authors;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title, AuthorId")] Book book) 
        {
            using(context )
            {
                context.Books.Add(book);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}
