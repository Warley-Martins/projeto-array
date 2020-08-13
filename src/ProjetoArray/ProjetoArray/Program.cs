using System;

namespace ProjetoArray
{
    class Program
    {
        private static ListaDeObjetosGenerica<Teste> obj;

        static void Main(string[] args)
        {
            obj = new ListaDeObjetosGenerica<Teste>();
            Console.WriteLine("Programa de implementação da lógica de uma List");

            do //Inicio do loop do programa
            {
                int opcaoMenuPrincipal;
                do      //Inicio loop menu inicial
                {
                    PrintarMenuPrincipal();
                    opcaoMenuPrincipal = int.Parse(Console.ReadLine());
                } while (opcaoMenuPrincipal < 0 || opcaoMenuPrincipal > 4); //Fim loop menu inicial

                switch (opcaoMenuPrincipal)
                {
                    case 1:     // Adicionar Elemento
                        AdicionarElemento();
                        break;
                    case 2:     // Remover Elemento
                        AdicionarVarios();
                        break;
                    case 3:     // Adicionar Varios Elementos
                        RemoverElemento();
                        break;
                    case 4: //Printar Lista
                        PrintarLista();
                        break;
                    case 0: // Encerrar
                        Console.WriteLine("\n\tPrograma Encerrado!!!");
                        return;
                }
            } while (true); //Fim do loop do programa
        }

        private static void PrintarMenuPrincipal()
        {
            Console.Write("\nDigite a opção desejada:" +
                          "\n(1). Adicionar um novo elemento" +
                          "\n(2). Adicionar varios elementos" +
                          "\n(3). Remover um elemento" +
                          "\n(4). Printar lista" +
                          "\n(0). Encerrar" +
                          "\nOpção Desejada: ");
        }
        private static void AdicionarElemento()
        {
            Console.Write("\n\tAdicionando um novo elemento" +
                          "\nDigite o valor desejado: ");
            string valorAdicionado = Console.ReadLine();
            Teste t = new Teste(valorAdicionado);
            obj.Adicionar(t);
        }
        private static void AdicionarVarios()
        {
            Console.Write("\n\tAdicionando varios elementos" +
                          "\nDigite o valor de elementos que deseja adicionar: ");
            var tamanho = int.Parse(Console.ReadLine());
            Teste[] ListaAuxiliar = new Teste[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o elemento {i + 1} : ");
                var nome = Console.ReadLine();
                ListaAuxiliar[i] = new Teste(nome);
            }
            obj.AdicionarVarios(ListaAuxiliar);
        }

        private static void RemoverElemento()
        {
            Console.Write("\n\tRemovendo um elemento" +
                          "\nDigite o valor desejado: ");
            var valorRemovido = Console.ReadLine();
            Teste t = new Teste(valorRemovido);
            Console.WriteLine(t);
            obj.Remover(t);
        }
        private static void PrintarLista()
        {
            foreach (var item in obj.ListaGenerica)
            {
                if(item != null)
                Console.WriteLine(item);
            }
        }

    }
}
