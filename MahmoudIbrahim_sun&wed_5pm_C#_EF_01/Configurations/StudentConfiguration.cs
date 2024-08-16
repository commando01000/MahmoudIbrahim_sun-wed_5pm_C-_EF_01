using MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_01.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Configure Student -> Department with Cascade Delete
            builder
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DepartmentId) // Specify the foreign key in the Student entity
                .OnDelete(DeleteBehavior.SetNull);  // SetNull delete for Student -> Department
        }
    }
}
