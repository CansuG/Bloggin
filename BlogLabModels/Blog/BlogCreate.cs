using System;
using System.ComponentModel.DataAnnotations;

namespace BlogLabModels.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(10, ErrorMessage = "Must be 10-50 characters")]
        [MaxLength(50, ErrorMessage = "Must be 10-50 characters")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(300, ErrorMessage = "Must be 300-3000 characters")]
        [MaxLength(3000, ErrorMessage = "Must be 300-3000 characters")]
        public String Content { get; set; }

        public int? PhotoId { get; set; }
    }
}
