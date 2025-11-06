using Microsoft.AspNetCore.Mvc;
using StudentRecordsApp.Data;
using StudentRecordsApp.Models;

namespace StudentRecordsApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index)); // ✅ Redirect after save
            }
            return View(student);
        }

        // GET: Students
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
    }
}
