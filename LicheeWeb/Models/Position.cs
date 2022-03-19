using System.ComponentModel.DataAnnotations;

namespace LicheeWeb.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "描述")]
        public string Description { get; set; } = string.Empty;
    }
}
