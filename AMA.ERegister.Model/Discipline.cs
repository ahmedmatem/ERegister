namespace AMA.ERegister.Model
{
    using AMA.ERegister.Model.Abstracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Discipline : SchoolObject
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string GroupId { get; set; }

        // navigation properties

        public virtual Group Group { get; set; }
    }
}
