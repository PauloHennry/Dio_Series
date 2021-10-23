using System.Collections.Generic;

namespace Dio.Series.Interface
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPOrId(int id);

        void Insere(T entidade);
        void Exclui(int id);

        void Atualiza(int id, T entidade);

        int ProximoId();

    }
}