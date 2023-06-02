using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _812WebMVCPractice.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]

        [StringLength(200)] //限制数据库长度
        public string Name { get; set; }
        public int Gender { get; set; }
        [Required]

        [StringLength(200)]
        public string Major { get; set; }
        public DateTime EntranceDate { get; set; }
    }
}