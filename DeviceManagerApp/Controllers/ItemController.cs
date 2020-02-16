using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeviceManagerApp.Data;
using DeviceManagerApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagerApp.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class ItemController : ControllerBase
    //{
    //}
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IDocumentDBRepository<Item> Repository;
        public ItemController(IDocumentDBRepository<Item> Repository)
        {
           this.Repository = Repository;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var res = await Repository.GetItemsAsync(d => !d.Completed);
            return Ok(res);
        }



        //#pragma warning disable 1998
        //        [ActionName("Create")]
        //        public async Task<IActionResult> CreateAsync()
        //        {
        //            return View();
        //        }
        //#pragma warning restore 1998

        //        [HttpPost]
        //        [ActionName("Create")]
        //        [ValidateAntiForgeryToken]
        //        public async Task<ActionResult> CreateAsync([Bind("Id,Name,Description,Completed")] Item item)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                await Repository.CreateItemAsync(item);
        //                return RedirectToAction("Index");
        //            }

        //            return View(item);
        //        }

        //        [HttpPost]
        //        [ActionName("Edit")]
        //        [ValidateAntiForgeryToken]
        //        public async Task<ActionResult> EditAsync([Bind("Id,Name,Description,Completed")] Item item)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                await Repository.UpdateItemAsync(item.Id, item);
        //                return RedirectToAction("Index");
        //            }

        //            return View(item);
        //        }

        //        [ActionName("Edit")]
        //        public async Task<ActionResult> EditAsync(string id)
        //        {
        //            if (id == null)
        //            {
        //                return BadRequest();
        //            }

        //            Item item = await Repository.GetItemAsync(id);
        //            if (item == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(item);
        //        }

        //        [ActionName("Delete")]
        //        public async Task<ActionResult> DeleteAsync(string id)
        //        {
        //            if (id == null)
        //            {
        //                return BadRequest();
        //            }

        //            Item item = await Repository.GetItemAsync(id);
        //            if (item == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(item);
        //        }

        //        [HttpPost]
        //        [ActionName("Delete")]
        //        [ValidateAntiForgeryToken]
        //        public async Task<ActionResult> DeleteConfirmedAsync([Bind("Id")] string id)
        //        {
        //            await Repository.DeleteItemAsync(id);
        //            return RedirectToAction("Index");
        //        }

        //        [ActionName("Details")]
        //        public async Task<ActionResult> DetailsAsync(string id)
        //        {
        //            Item item = await Repository.GetItemAsync(id);
        //            return View(item);
        //        }
    }
}