using DIO_Series.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIO_Series.Classes
{
    class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(Genero genero, string titulo, string descricao, int ano, bool excluido)
        {
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = excluido;
        }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
         
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Título: " + Titulo + Environment.NewLine;
            retorno += "Descricao: " + Descricao + Environment.NewLine;
            retorno += "Ano de início: " + Ano + Environment.NewLine;
            retorno += "Excluido: " + Excluido;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }

        public int RetornaId()
        {
            return Id;
        }

        public void Exclui()
        {
            Excluido = true;
        }

    }
}
