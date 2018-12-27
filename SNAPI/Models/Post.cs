namespace SNAPI.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Content { get; set; }
    }
}