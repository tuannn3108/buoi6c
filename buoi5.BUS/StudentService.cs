using buoi5.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5.BUS
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            Model1 context = new Model1();
            return context.Students.ToList();
        }
        public List<Student> GetAllHasNoMajor()
        {
            Model1 context = new Model1();
            return context.Students.Where(p=>p.MajorID == null).ToList();
        }
        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            Model1 context = new Model1();
            return context.Students.Where(p=>p.MajorID == null && p.FacultyID == facultyID).ToList();
        }
        public Student FindById(string studentID)
        {
            Model1 context = new Model1();
            return context.Students.FirstOrDefault(p => p.StudentID == studentID);
        }
        public void InsertUpdate( Student s)
        {
            Model1 context = new Model1();
            context.Students.Add(s);
            context.SaveChanges();
        }
    }
}
