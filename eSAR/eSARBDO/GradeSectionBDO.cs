using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSARBDO
{
    public class GradeSectionBDO
    {
        //List<StudentEnrolledBDO> studentEnrolled = new List<StudentEnrolledBDO>();
        //List<SubjectAssignmentBDO> subjectsEnrolled = new List<SubjectAssignmentBDO>();
        public int GradeSectionCode { get; set; }
        public string GradeLevel { get; set; }
        public string Section { get; set; }
        public string HomeRoomNumber { get; set; }
        public string SY { get; set; }
        public string HomeRoomTeacherId { get; set; }
        public bool Deactivated { get; set; }

        public TeacherBDO HomeRoomTeacher { get; set; }
        public RoomBDO HomeRoom { get; set; }
        //public List<StudentEnrolledBDO> EnrolledStudents {
        //    get { return studentEnrolled; }
        //    set { studentEnrolled = value; }
        //}
        //public List<SubjectAssignmentBDO> DefaultSubjects {
        //    get { return subjectsEnrolled; }
        //    set { subjectsEnrolled = value; }
        //}


    }
}
