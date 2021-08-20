using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diolivros
{
    class Livros :EntidadeBase
    {
        private Genero Genero{ get; set; }
        private string Titulo{ get; set; }
        private string Sinopse{ get; set; }
        private string Editora { get; set; }
        private string MSDN { get; set; }
        private int AnoLancamento { get; set; }
        private bool Excluido { get; set; }
        private bool Emprestado { get; set; }
        private string DataEmprestimo { get; set; }
        private string PessoaEmprestimo { get; set; }

        public Livros()
        {

        }

        public Livros(int id, Genero genero, string titulo, string sinopse, string editora, string mSDN, int anoLancamento)
        {
            Genero = genero;
            Titulo = titulo;
            Sinopse = sinopse;
            Editora = editora;
            MSDN = mSDN;
            AnoLancamento = anoLancamento;
        }

        public Livros(int id, Genero genero, string titulo, string sinopse, string editora, string mSDN, int anoLancamento, bool excluido, bool emprestado, string dataEmprestimo, string pessoaEmprestimo)
        {
            Id = Id;
            Genero = genero;
            Titulo = titulo;
            Sinopse = sinopse;
            Editora = editora;
            MSDN = mSDN;
            AnoLancamento = anoLancamento;
            Excluido = excluido;
            Emprestado = emprestado;
            DataEmprestimo = dataEmprestimo;
            PessoaEmprestimo = pessoaEmprestimo;
        }

        public override string ToString()
        {
            //Environment.NewLine;
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Sinópse: " + this.Sinopse + Environment.NewLine;
            retorno += "Editora " + Editora + Environment.NewLine;
            retorno += "MSDN: " + MSDN + Environment.NewLine;
            retorno += "Ano de Lancamento: " + AnoLancamento + Environment.NewLine;
            return retorno; 
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;

        }
        public void Emprestar()
        {
            this.Emprestado= true;

        }
    }
}
