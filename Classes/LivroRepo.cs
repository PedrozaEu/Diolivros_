using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diolivros.Interfaces;


namespace Diolivros
{
    class LivroRepo : IRepositorio<Livros>
    {
        private List<Livros> listalivros = new List<Livros>();
        public void Atualiza(int id, Livros entidade)
        {
            listalivros[id] = entidade;
        }

        public void Exclui(int id)
        {
            listalivros[id].Excluir();
        }

        public void Empresta(int id)
        {
            listalivros[id].Emprestar();
        }

        public void Insere(Livros entidade)
        {
            listalivros.Add(entidade);
        }

        public List<Livros> Lista()
        {
            return listalivros;
        
        }

        public int ProximoId()
        {
            return listalivros.Count;
        }

        public Livros RetornaPorId(int id)
        {
            return listalivros[id];
        }
    }
}
