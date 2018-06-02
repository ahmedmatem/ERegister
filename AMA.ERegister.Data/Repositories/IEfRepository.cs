namespace AMA.ERegister.Data.Repositories
{
    using AMA.ERegister.Model.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEfRepository<T>
        where T : class, IDeletable
    {
        IQueryable<T> All();

        IQueryable<T> AllWithDeleted();

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        //void HardDelete(T entity);

        //void Save();
    }
}
