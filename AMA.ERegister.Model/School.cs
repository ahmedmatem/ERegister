namespace AMA.ERegister.Model
{
    using AMA.ERegister.Model.Abstracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School : SchoolObject
    {
        public School()
        {
            this.Teachers = new HashSet<Teacher>();
        }

        // navigation properties

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
