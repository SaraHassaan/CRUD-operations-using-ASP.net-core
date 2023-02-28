using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMangement.Models
{
    public class StudentRepository : IStudentRepository
    {   
        private ApplicationDbContext context;
        public StudentRepository(ApplicationDbContext applicationDbContext)
        {
            this.context = applicationDbContext;
        }
        public Student Add(Student student)
        {
            context.students.Add(student);
            context.SaveChanges();

            return student;
        }

        public Student Delete(int id)
        {
            Student student = context.students.FirstOrDefault(stu => stu.Id == id);
            if(student != null)
            {
                context.students.Remove(student);
                context.SaveChanges();
            }

            return student;
        }

        public Student Edit(Student student)
        {
            Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entityEntry = context.students.Attach(student);
            entityEntry.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return student;
            //Student updatedStudent = context.students.FirstOrDefault(stu => stu.Id == student.Id);
            //if(updatedStudent != null)
            //{
            //    updatedStudent.Name = student.Name;
            //    updatedStudent.Grade = student.Grade;
            //    updatedStudent.BirthDate = student.BirthDate;

            //    context.students.Update(updatedStudent);

            //}

        }

        public IEnumerable<Student> GetAllStudentInGrade(int grade)
        {
            IEnumerable<Student> students = context.students.Where(s => s.Grade == grade);
            return students;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return context.students;
        }

        public Student Search(int id)
        {
            Student student = context.students.FirstOrDefault(stu => stu.Id == id);
            return student;
        }
    }
}
