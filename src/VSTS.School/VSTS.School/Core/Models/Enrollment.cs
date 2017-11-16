using VSTS.School.Application.Enums;

namespace VSTS.School.Core.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public  Grade? Grade { get; set; }

       
        public Course Course { get; set; }

        public Student Student { get; set; }

    }
}