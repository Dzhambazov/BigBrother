using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSchool.Models
{
    public class Subject
    {
        private ICollection<Teacher> _teachers;

        public Subject()
        {
            this.Teachers = new HashSet<Teacher>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual School School { get; set; }


        public ICollection<Teacher> Teachers
        {
            get { return _teachers; }
            set
            {
                this._teachers = value;
            }
        }

    }
}
