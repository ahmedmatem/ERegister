namespace AMA.ERegister.Model.Contracts
{
    using System;

    public interface IDeletable
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
