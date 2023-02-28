using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMangement.Models
{
    public interface IStudentRepository
    {
        public Student Add(Student student);
        public Student Edit(Student student);
        public Student Delete(int id);
        public Student Search(int id);
        public IEnumerable<Student> GetAllStudentInGrade(int Grade);
        public IEnumerable<Student> GetAllStudents();


    }
}
