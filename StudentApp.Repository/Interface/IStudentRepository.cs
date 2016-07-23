using StudentApp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentApp.Repository.Interface
{
    public interface IStudentRepository
    {
         Task<List<Student>> Get();
         Task<bool> Add(Student student);

    }
}
