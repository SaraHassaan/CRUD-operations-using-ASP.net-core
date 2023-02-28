using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMangement.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Grade { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-ddT00:00}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
    }
}
