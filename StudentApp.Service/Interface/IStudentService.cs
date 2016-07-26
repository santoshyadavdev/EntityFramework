using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp.Model;

namespace StudentApp.Service.Interface
{
    public interface IStudentService
    {
        Task<List<Student>> Get();
        Task<bool> Add(Student student);

    }
}
