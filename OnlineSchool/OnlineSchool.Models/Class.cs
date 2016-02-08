using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool.Models
{
    public class Class
    {
        private ICollection<Student> _students;
        private Teacher _teacher;

        public Class()
        {
            this.Students = new HashSet<Student>();
        }

        [Key]
        public int Id { get; set; }

        public virtual School School { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual Teacher Teacher
        {
            get { return this._teacher; }
            set
            {
                if (this.Subject.Teachers.Contains(value))
                {
                    this._teacher = value;
                }
            }
        }


        public virtual ICollection<Student> Students
        {
            get { return _students; }
            set
            {
                this._students = value;
            }
        }
    }
}
