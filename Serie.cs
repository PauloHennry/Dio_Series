using System;

namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        private Genero genero{ get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano{get; set;}

        private bool Exluido{get; set;}


        //Metodo

        public Serie (int id, Genero genero, string Titulo, string Descricao,int Ano)
        {
            this.id = id;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Exluido = false;
        }
        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            String retorno = "";
            retorno += "Genero: " + this.genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de inicio: " + this.Ano;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaid()
        {
            return this.id;
        }
        public void Excluir()
        {
            this.Exluido = true;
        }
    }
}