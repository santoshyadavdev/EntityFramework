using StudentApp.Model;
using StudentApp.Service.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {

        private IStudentService _service;
        
        public StudentController(IStudentService service)
        {
            this._service = service;
        }

        [HttpGet]
        public async Task<JsonResult> Get()
        {
            return Json(await _service.Get(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<bool> Post(Student student)
        {
            return await _service.Add(student);
        }

    }
}
