using System.ComponentModel.DataAnnotations;

namespace ListsHelpersDemo.Models
{
    public class Group
    {
        public int Id { get; set; }

        [Display(Name = "Group name")]
        public string Name { get; set; }
    }
}