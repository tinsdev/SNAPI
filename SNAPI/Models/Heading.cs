using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SNAPI.Models
{
    public class Heading
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string URL { get; set; }
    }
}