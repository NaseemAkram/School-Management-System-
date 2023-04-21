using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailModel> Get()
        {
            StudentAdmissionDetailModel admissionobj1 = new StudentAdmissionDetailModel();
            StudentAdmissionDetailModel admissionobj2 = new StudentAdmissionDetailModel();
            admissionobj1.StudentID = 1;
            admissionobj1.StudentName = "Adam";
            admissionobj1.StudentClass = "X";
            admissionobj1.DateofJoining = DateTime.Now;
            admissionobj2.StudentID = 2;
            admissionobj2.StudentName = "Brad";
            admissionobj2.StudentClass = "IX";
            admissionobj2.DateofJoining = DateTime.Now;
            List<StudentAdmissionDetailModel> listofobj = new List<StudentAdmissionDetailModel>
            {
                admissionobj1,
                admissionobj2
            };
            return listofobj;
        }
    }
}
