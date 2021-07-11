using System;
using System.Collections.Generic;
using System.Text;

namespace DIO_Series.Interfaces
{
    interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T objeto);
        void Excluir(int id);
        void Atualizar(int id, T objeto);
        int ProximoId();
    }
}
