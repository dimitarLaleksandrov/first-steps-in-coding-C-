using Homies.Models;
using Homies.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Homies.Controllers
{
    public class EventController : Controller
    {

        private readonly IEventServices eventServices;


        protected string GetUserId()
        {
            string id = string.Empty;

            if (User != null)
            {
                id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            }

            return id;
        }


        public EventController(IEventServices eventServices)
        {
            this.eventServices = eventServices;
        }




        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = await eventServices.GetAddEventFormModelAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEventFormModel eventModel)
        {
            if (!ModelState.IsValid)
            {
                return View(eventModel);

            }

            var userId = GetUserId();
            await eventServices.AddEventAsync(eventModel, userId);

            return RedirectToAction(nameof(All));

        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var _event = await eventServices.GetEventByIdForEditAsync(id);

            if (_event == null)
            {
                return RedirectToAction(nameof(All));
            }

            return View(_event);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, AddEventFormModel eventModel)
        {
            

            if (!ModelState.IsValid)
            {
                return View(eventModel);

            }

            await eventServices.EdiEventAsync(id, eventModel);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {

            var model = await eventServices.GetAllEventsAsync();

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Join(int id)
        {

            var userId = GetUserId();

            await eventServices.Join(userId, id);

            return View("/Event/Joined");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {

            var _event = await eventServices.GetEventByIdForEditAsync(id);

            return View(_event);
            
        }


        [HttpGet]
        public async Task<IActionResult> Joink(int id)
        {

            var userId = GetUserId();

            await eventServices.Join(userId, id);

            return View("/Event/Joined");
        }



        //    public async Task<IActionResult> Leave(int id)
        //    {
        //        var book = await eventServices.GetEventByIdForEditAsync(id);

        //        if (book == null)
        //        {
        //            return RedirectToAction(nameof(All));
        //        }

        //        var userId = GetUserId();

        //        await s.RemoveBookFromCollection(userId, book);

        //        return RedirectToAction(nameof(Mine));
        //    }
        //
        //
    }
}
