using DIO_Series.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIO_Series.Classes
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();
        public void Atualizar(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }

        public void Excluir(int id)
        {
            ListaSerie[id].Exclui();
        }

        public void Insere(Serie objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}
