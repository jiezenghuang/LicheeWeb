using System.ComponentModel.DataAnnotations;

namespace LicheeWeb.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "客户部门")]
        public bool IsCustomer { get; set; }
        [Display(Name = "负责人")]
        public ICollection<Staff> Manager { get; set; }
        [Display(Name = "描述")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "上级部门")]
        public Department? Parent { get; set; }
        [Display(Name = "下级部门")]
        public ICollection<Department> Children { get; set; }
    }
}
