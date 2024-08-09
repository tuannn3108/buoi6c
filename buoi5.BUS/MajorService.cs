using buoi5.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5.BUS
{
    public class MajorService
    {
        public List<Major> GetAllByFaculty(int facultyId)
        {
            Model1 context = new Model1();
            return context.Majors.Where(p=>p.FacultyID == facultyId).ToList();
        }
    }
}
