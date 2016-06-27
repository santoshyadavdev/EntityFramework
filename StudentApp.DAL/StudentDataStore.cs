using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Model;
using System.Data.Entity;

namespace StudentApp.DAL
{
    public class StudentDataStore
    {
        private StudentContext _context = new StudentContext();

        public async Task<List<Student>> GetStudentList()
        {
            return await _context.Student.ToListAsync();
        }

        public async Task<bool> AddStudent(Student student)
        {
            student.CreatedDate = DateTime.Now;
            _context.Student.Add(student);
            int x = await _context.SaveChangesAsync();
            return x == 0 ? false : true;
        }

        public async Task<bool> UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            student.ModeifiedDate = DateTime.Now;
            int x = await _context.SaveChangesAsync();
            return x == 0 ? false : true;
        }

    }
}
