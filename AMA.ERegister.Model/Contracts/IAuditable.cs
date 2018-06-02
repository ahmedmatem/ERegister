namespace AMA.ERegister.Model.Contracts
{
    using System;

    public interface IAuditable
    {
        DateTime? CreatedOn { set; get; }

        DateTime? ModifiedOn { set; get; }
    }
}
