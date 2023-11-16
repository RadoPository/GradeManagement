using GradeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GradeManagement.Controllers
{
    public class StudentController : Controller
    {
        
            private readonly SchoolContext db = new SchoolContext();

            // GET: Student/Login
            public ActionResult Login()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Login(StudentLoginViewModel model)
            {
                if (ModelState.IsValid)
                {
                    var student = db.Students
                                    .FirstOrDefault(s => s.Email == model.Email && s.Password == model.Password);

                    if (student != null)
                    {
                        // In a real application, you'd set up authentication here
                        // For example, using FormsAuthentication.SetAuthCookie
                        return RedirectToAction("Index", "Home"); // Redirect to the main page after login
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid email or password");
                    }
                }

                return View(model);
            }


            // GET: StudentController
            public ActionResult Index()
        {
            return View();
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
