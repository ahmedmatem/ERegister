namespace AMA.ERegister.Model
{
    using AMA.ERegister.Model.Abstracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Person
    {
        public string GroupId { get; set; }

        // naviagtion properties

        public virtual Group Group { get; set; }
    }
}
