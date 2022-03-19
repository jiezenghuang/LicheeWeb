using System.ComponentModel.DataAnnotations;

namespace LicheeWeb.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "部门")]
        public Department Department { get; set; }
        [Display(Name = "职位")]
        public Position Position { get; set; }

    }
}
