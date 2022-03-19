using System.ComponentModel.DataAnnotations;

namespace LicheeWeb.Models
{
    public enum ProjectType
    {
        [Display(Name = "交付")]
        Delivery,
        [Display(Name = "自研")]
        Research,
        [Display(Name = "专题")]
        Topic,
        [Display(Name = "其他")]
        Other
    }

    public class Project
    {
        public int Id { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "类型")]
        public ProjectType Type { get; set; }
        [Display(Name = "目标")]
        public string Goal { get; set; } = string.Empty;
        [Display(Name = "描述")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "编码")]
        public string Code { get; set; } = string.Empty;
        [Display(Name = "责任人")]
        public Staff Manager { get; set; }
        [Display(Name = "里程碑")]
        public ICollection<Milestone> Milestones { get; set; }
    }
}
