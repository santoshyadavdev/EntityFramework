using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using StudentApp.Model;
using StudentApp.DAL;

namespace StudentApp.Controllers
{
    public class StudentController : ApiController
    {
        private StudentDataStore _store = new StudentDataStore();
        public async Task<List<Student>> Get()
        {
            return await _store.GetStudentList();
        }

        public async Task<bool> Post(Student student)
        {
            return await _store.AddStudent(student);
        }

        public async Task<bool> Put(Student student)
        {
            return await _store.UpdateStudent(student);
        }

    }
}
