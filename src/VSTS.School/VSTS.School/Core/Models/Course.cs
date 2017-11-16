using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VSTS.School.Core.Models
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Course
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public  ICollection<Enrollment> Enrollments { get; set; }
    }
}