using System.ComponentModel.DataAnnotations;

namespace Task_PurpleBuzz.ViewModels.WorkCategory
{
    public class WorkCategoryCreateVM
    {
        [MaxLength(10, ErrorMessage = "Name must be at least 10 characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Description can't be longer than 100 characters")]
        public string Desc { get; set; }
    }
}
