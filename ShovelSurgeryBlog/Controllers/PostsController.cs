using Microsoft.AspNetCore.Mvc;
using ShovelSurgeryBlog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShovelSurgeryBlog.Controllers
{
    public class PostsController : Controller
    {
        private readonly DataManager dataManager;

        public PostsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PagePosts");
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
