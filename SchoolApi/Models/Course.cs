using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    [Table("courses")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }
    }
}