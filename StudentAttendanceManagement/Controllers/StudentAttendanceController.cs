using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Model;

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailModel> Get()
        {
            StudentAttendanceDetailModel attendanceObj1 = new StudentAttendanceDetailModel();
            StudentAttendanceDetailModel attendanceObj2 = new StudentAttendanceDetailModel();
            attendanceObj1.StudentID = 1;
            attendanceObj1.StudentName = "Adam";
            attendanceObj1.AttendencePercentage = 83.02;
            attendanceObj2.StudentID = 2;
            attendanceObj2.StudentName = "Brad";
            attendanceObj2.AttendencePercentage = 71.02;
            List<StudentAttendanceDetailModel> listObj = new List<StudentAttendanceDetailModel>
            {
                attendanceObj1,
                attendanceObj2
            };
            return listObj;
        }
    }
}
