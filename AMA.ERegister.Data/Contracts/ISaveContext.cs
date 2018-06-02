namespace AMA.ERegister.Data.Contracts
{
    public interface ISaveContext
    {
        MsSqlDbContext Context { get; }

        void Commit();
    }
}
