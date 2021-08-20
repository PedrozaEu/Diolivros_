using System;

namespace Diolivros
{
    class Program
    {
        static LivroRepo repositorio = new LivroRepo();
        static void Main(string[] args)
        {
            static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("==========>Organizalivros: Seu jeito retrô de catalogar seus livros<==========");
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("");
                Console.WriteLine("1 - Listar Livros");
                Console.WriteLine("2 - Cadastrar novo Livro");
                Console.WriteLine("3 - Atualizar Livro");
                Console.WriteLine("4 - Excluir Livro");
                Console.WriteLine("5 - Emprestar Livro");
                Console.WriteLine("6 - Visualizar Livro");
                Console.WriteLine("C - Limpar Tela");
                Console.WriteLine("X - Sair");

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
            }


            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarLivros();
                        break;

                    case "2":
                        InserirLivro();
                            break;

                    case "3":
                        // listarlivros();
                        break;

                    case "4":
                        // listarlivros();
                        break;

                    case "5":
                        // listarlivros();
                        break;

                    case "6":
                        // listarlivros();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar o Organizalivros!");
            Console.ReadLine();

        }

        //metodos
        public static void ListarLivros()
        {
            Console.WriteLine("Listar Livros");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Não há livros cadastrados");
                return;
            }

            foreach (var livro in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", livro.retornaId(), livro.retornaTitulo());

            }
        }

        public static void InserirLivro()
        {
            Console.WriteLine("Inserir Livro");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o genero entre as opções a cima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo do Livro: ");
            string entradaTitulo = Console.ReadLine();
            
            Console.WriteLine("Digite o Ano de Lançamento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sinopse: ");
            string entradaSinopse = Console.ReadLine();

            Console.WriteLine("Digite o MSDN: ");
            string entradaMSDN = Console.ReadLine();

            Console.WriteLine("Digite a Editora: ");
            string entradaEditora = Console.ReadLine();

            Livros novolivro = new Livros(  id: repositorio.ProximoId(),
                                            genero:(Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            anoLancamento: entradaAno,      
                                            sinopse: entradaSinopse,
                                            mSDN: entradaMSDN,
                                            editora: entradaEditora);


        }

        public static void ExcluirLivro()
        {

        }
    }
}

