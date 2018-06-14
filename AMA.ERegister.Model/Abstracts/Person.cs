namespace AMA.ERegister.Model.Abstracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Person : SchoolObject
    {
        public string FirstName { get; set; }

        public string FatherName { get; set; }

        public string LastName { get; set; }
    }
}
