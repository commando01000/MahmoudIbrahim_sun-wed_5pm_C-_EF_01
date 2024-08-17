using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(80)")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Course cannot exceed 80 characters")]
        public string Name { get; set; }

        [Required]
        [Range(1, 120, ErrorMessage = "Duration cannot be less than 1 or greater than 120")]
        public double Duration { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "Description cannot exceed 300 characters")]
        public string? Description { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }

        public List<InstructorCourse> InstructorCourses { get; set; }

        [ForeignKey("TopicId")]
        public int TopicId { get; set; }

        public Topic Topic { get; set; }
    }
}
