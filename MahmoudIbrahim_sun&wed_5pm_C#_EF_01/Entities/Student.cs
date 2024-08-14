using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(60)")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Name cannot exceed 60 characters")]
        public string FName { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(60)")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Name cannot exceed 60 characters")]
        public string LName { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "Address cannot exceed 300 characters")]       
        public string? Address { get; set; }
        
        [Required]
        public int Age { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
