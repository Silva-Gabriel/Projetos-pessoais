using System.Environment; 

namespace CadastroSeries
{
    public class Serie : EntidadeBase
    {
        public class  Serie : EntidadeBase
        {
            private Genero Genero {get; set; } 
            
            private string Titulo { get; set; }
            
            private string Descricao { get; set; }
            
            private int Ano { get; set; }

        }

        public Serie(int id, Genero genero, string titulo,string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string str = "";
            str += $"Gênero: {this.Genero} {Environment.NewLine}";
            str += $"Título: {this.Titulo} {Environment.NewLine}";
            str += $"Descrição: {this.Descricao} {Environment.NewLine}";
            str += $"Ano de início: {this.Ano} {Environment.NewLine}";
            return str;
        }

        public string retornarTitulo()
        {
            return this.Titulo;
        }
        
        public RetornarId()
        {
            return this.Id;
        }
    }
}