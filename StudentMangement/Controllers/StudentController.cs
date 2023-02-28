using Microsoft.AspNetCore.Mvc;
using StudentMangement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMangement.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> model = studentRepository.GetAllStudents();

            return View(model);
 
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.id = id;

            Student student = studentRepository.Search(id);
            if(student != null)
            {
                return View(student);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            Student student = new Student();
            return View(student);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                student = studentRepository.Add(student);
                return RedirectToAction("Index");
            }
            
            return View(student);
        }

        [HttpGet]
        public IActionResult ModifyStudent(int? id)
        {
            Student student = studentRepository.Search(id??0);
            if(student != null)
            {
                return View(student);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult ModifyStudent(Student updatedStudent)
        {
            if (ModelState.IsValid)
            {
                studentRepository.Edit(updatedStudent);
                return RedirectToAction("Index");
            }
            return View(updatedStudent);           
        }

        public IActionResult DeleteStudent(int id)
        {
            if(studentRepository.Delete(id)!= null)
            {
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
