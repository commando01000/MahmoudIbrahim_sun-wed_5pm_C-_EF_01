using MahmoudIbrahim_sun_wed_5pm_C__EF_01.Contexts;
using MahmoudIbrahim_sun_wed_5pm_C__EF_01.Entities;

namespace MahmoudIbrahim_sun_wed_5pm_C__EF_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentDBClass())
            {
                Department dept = new Department();
                dept.Name = "IT";
                dept.HireDate = DateTime.Now;
                dept.Students = new List<Student>();
                dept.Instructors = new List<Instructor>();
                db.Departments.Add(dept);
                db.SaveChanges();
            }

            using (var db = new StudentDBClass())
            {
                Department dept2 = new Department();
                dept2.Name = "HR";
                dept2.HireDate = DateTime.Now;
                dept2.Students = new List<Student>();
                dept2.Instructors = new List<Instructor>();
                db.Departments.Add(dept2);
                db.SaveChanges();
                Console.WriteLine(db.Entry(dept2).State.ToString());
            }
        }
    }
}
