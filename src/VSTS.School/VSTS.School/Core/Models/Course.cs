using System.Collections.Generic;

namespace VSTS.School.Core.Models
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Course
    {
        public int CourseId { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public  ICollection<Enrollment> Enrollments { get; set; }
    }
}