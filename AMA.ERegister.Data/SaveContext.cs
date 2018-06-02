﻿namespace AMA.ERegister.Data
{
    using AMA.ERegister.Data.Contracts;

    public class SaveContext : ISaveContext
    {
        private readonly MsSqlDbContext dbContext;

        public SaveContext(MsSqlDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public MsSqlDbContext Context => dbContext;

        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
