using System.ComponentModel.DataAnnotations;

namespace LicheeWeb.Models
{
    public class Mission
    {
        public int Id { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "描述")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "责任人")]
        public Staff Manager { get; set; }
        [Display(Name = "上级任务")]
        public Mission? Parent { get; set; }
        [Display(Name = "下级任务")]
        public ICollection<Mission> Children { get; set; }
        [Display(Name = "开始时间")]
        public DateTime StartTime { get; set; }
        [Display(Name = "结束时间")]
        public DateTime FinishTime { get; set; }
        [Display(Name = "投入比")]
        public float    Ratio { get; set; }
        [Display(Name = "进展")]
        public float Progress { get; set; }
        [Display(Name = "是否完成")]
        public bool IsCompleted { get; set; }
        [Display(Name = "完成时间")]
        public DateTime? CompleteTime { get; set; }
    }
}
