namespace AMA.ERegister.Model
{
    using System.Collections.Generic;

    using AMA.ERegister.Model.Abstracts;

    public class Group : SchoolObject
    {
        public Group()
        {
            this.Students = new HashSet<Student>();
            this.Disciplines = new HashSet<Discipline>();
        }

        public string Name { get; set; }

        public string TeacherId { get; set; }

        // navigation properties

        public virtual ICollection<Student> Students { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Discipline> Disciplines { get; set; }
    }
}
