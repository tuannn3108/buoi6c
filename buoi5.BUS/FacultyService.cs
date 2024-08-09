using buoi5.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5.BUS
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            Model1 context = new Model1();
            return context.Faculties.ToList();
        }
    }
}
