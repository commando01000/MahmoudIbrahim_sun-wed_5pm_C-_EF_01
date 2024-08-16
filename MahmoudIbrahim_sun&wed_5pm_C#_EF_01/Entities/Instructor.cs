using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities
{
    public class Instructor
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

        [DataType(DataType.Currency)]
        public int? Salary { get; set; }

        [DataType(DataType.Currency)]
        public int? Bonus { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "Address cannot exceed 300 characters")]
        public string? Address { get; set; }

        [Required]
        public int HourRate { get; set; }
        public List<Course> Courses { get; set; }

        public int? dept_id { get; set; }

        //[NotMapped]
        //public int test { get; set; }
        public Department Department { get; set; }
    }
}
