using ModelAPI.Contracts;
using ModelAPI.Data;

namespace ModelAPI.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {

        #region [Propriedade]

        public modelFirstEntities _dataContext;

        #endregion

        #region[Construtor]

        public RepositoryCliente(modelFirstEntities context) : base(context)
        {
            _dataContext = context;
        }

        #endregion
    }
}