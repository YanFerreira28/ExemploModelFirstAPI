using ModelAPI.Contracts;
using ModelAPI.Data;

namespace ModelAPI.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        #region [Propriedade]

        public modelFirstEntities _data;

        #endregion

        #region[Construtor]

        public RepositoryProduto(modelFirstEntities data) : base(data)
        {
            _data = data;
        }

        #endregion
    }
}