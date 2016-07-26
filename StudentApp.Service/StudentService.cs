using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Service.Interface;
using StudentApp.Repository.Interface;
using StudentApp.Model;

namespace StudentApp.Service
{
    public class StudentService : IStudentService
    {
        private IStudentRepository __repo;
        public StudentService(IStudentRepository repo)
        {

            this.__repo = repo;
        }

        public async Task<bool> Add(Student student)
        {
            return await __repo.Add(student);
        }

        public async Task<List<Student>> Get()
        {
            return await __repo.Get();
        }
    }
}
