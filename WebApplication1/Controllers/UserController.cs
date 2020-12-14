using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }
        // GET: UserController
        public ActionResult Index()
        { var users = this.userService.Get();
            return View(users);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                this.userService.Create(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
                return NotFound();
            var user = this.userService.Get(id);
            if (user == null)
                return NotFound();
            return View(user);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, User user)
        {
            if (id != user.UserId)
                return NotFound();
            
            if (ModelState.IsValid)
            {
                this.userService.Update(id, user);
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
                return NotFound();

            var user = this.userService.Get(id);
            if (user == null)
                return NotFound();

            return View(user);
        }

        // POST: UserController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string id)
        {
            try
            {

                var user = this.userService.Get(id);

                if (id == null)
                    return NotFound();

                this.userService.Remove(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
