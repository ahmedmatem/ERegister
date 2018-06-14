namespace AMA.ERegister.Model
{
    using AMA.ERegister.Model.Abstracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Schedule : SchoolObject
    {
        public string TeacherId { get; set; }

        public string GroupId { get; set; }

        public string DisciplineId { get; set; }

        // navigation properties

        public virtual Teacher Teacher { get; set; }

        public virtual Group Group { get; set; }

        public virtual Discipline Discipline { get; set; }
    }
}
