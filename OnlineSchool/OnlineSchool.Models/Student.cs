using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public virtual School School { get; set; }

        public virtual Class Class { get; set; }
    }
}
        