namespace AMA.ERegister.Model
{
    using AMA.ERegister.Model.Abstracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Teacher : Person
    {
        public Teacher()
        {
            this.Schedules = new HashSet<Schedule>();
        }

        public string SchoolId { get; set; }

        public string GroupId { get; set; }

        // navigation properties

        public virtual School School { get; set; }

        public virtual Group Group { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
