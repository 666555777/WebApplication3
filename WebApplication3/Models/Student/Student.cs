using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.Student
{
    public class Student
    {
        [Key]
        public int LMUID { get; set; }
        public int Name { get; set; }
        public int Email { get; set; }
        public int FypTitle { get; set; }
    }
}
