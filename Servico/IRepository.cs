using System.Collections.Generic;

namespace Servico
{
    public interface IRepository<T> where T : class
    {
        T Inserir(T entidade);
        T Alterar(T entidade);
        void Excluir(int codigo);
        List<T> ListarTodas();
        T BuscarId(int codigo);
    }
}
