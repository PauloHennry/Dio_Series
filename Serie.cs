namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        private Genero genero{ get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano{get; set;}


        //Metodo

        public Serie (int id, Genero genero, string Titulo, string Descricao,int Ano)
        {
            this.id = id;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
        }
        public override string ToString()
        {
            // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string return = " ";
            return += "Genero: " + this.genero + Environmet.NewLine;
            return += "Titulo: " + this.Titulo + Environment.NewLine;
            return += "Descrição: " + this.Descricao + Environment.NewLinw;
            return += "Ano de inicio: " + this.Ano;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        internaç int retornaid()
        {
            return this.id;
        }
    }
}