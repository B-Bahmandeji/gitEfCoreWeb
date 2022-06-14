using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreWebDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCoreWebDemo.Controllers
{
    public class AuthorController : Controller
    {
        private readonly EFCoreWebDemoContext context;

        public AuthorController(EFCoreWebDemoContext context)
        {
            this.context = context;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            //dbcontext instantiated in using block to be sure is disposed properly
            using(context )
            {
                var model = await context.Authors.AsNoTracking().ToListAsync();//noTracking useful when result use in readonly, no need to change
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName, LastName")] Author author) 
        {
            using(context )
            {
                context.Add(author);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}
