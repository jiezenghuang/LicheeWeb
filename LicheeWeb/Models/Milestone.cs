using System.ComponentModel.DataAnnotations;

namespace LicheeWeb.Models
{
    public class Milestone
    {
        public int Id { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "描述")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "项目")]
        public Project Project { get; set; }
        [Display(Name = "时间点")]
        public DateTime DateTime { get; set; }
    }
}
