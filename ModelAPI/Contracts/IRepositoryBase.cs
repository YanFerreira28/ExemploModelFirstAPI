using System.Collections.Generic;

namespace ModelAPI.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        #region[Interface]

        IEnumerable<T> GetAll();

        T GetById(int id);

        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        void Commit();

        void Dispose();

        #endregion
    }
}
