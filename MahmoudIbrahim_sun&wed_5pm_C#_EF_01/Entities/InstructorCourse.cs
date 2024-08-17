using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities
{
    //[PrimaryKey(nameof(InstructorId), nameof(CourseId))]
    public class InstructorCourse
    {
        [ForeignKey(nameof(Instructor))]
        public int InstructorId { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }

        [Range(0, 100, ErrorMessage = "Evaluation must be between 0 and 100")]
        public int Evaluation { get; set; }
    }
}
