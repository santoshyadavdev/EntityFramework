using StudentApp.Model;
using StudentApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace StudentApp.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private StudentContext _context = new StudentContext();

        public StudentRepository(StudentContext context)
        {
            this._context = context;
        }

        public async Task<List<Student>> Get()
        {
            return await _context.Student.ToListAsync();
        }

        public async Task<bool> Add(Student student)
        {
            student.CreatedDate = DateTime.Now;
            _context.Student.Add(student);
            int x = await _context.SaveChangesAsync();
            return x == 0 ? false : true;
        }
    }
}
