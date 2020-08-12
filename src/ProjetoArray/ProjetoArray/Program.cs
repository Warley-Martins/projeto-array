using System;

namespace ProjetoArray
{
    class Program
    {
        private static ListaDeObjetosInt obj;

        static void Main(string[] args)
        {
            obj = new ListaDeObjetosInt();
            Console.WriteLine("Programa de implementação da lógica de uma List em um Array");
            
            //Teste
            //int i = 10;
            //obj.Adicionar(i);
            //obj.Adicionar(i);
            //obj.Adicionar(i);
            //obj.Adicionar(i);
            //obj.Adicionar(i);
            //obj.Adicionar(i);

            //obj.Remover(10);
            //obj.Remover(10);
            //obj.Remover(10);
            //obj.Remover(10);
            //obj.Remover(10);
            //for (int i2 = 0; i2 < 6; i2++)
            //{
            //    Console.WriteLine(obj.ListaDeInteiros[i2]);
            //}
            //Console.ReadLine();

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
            var valorAdicionado = int.Parse(Console.ReadLine());
            obj.Adicionar(valorAdicionado);
        }
        private static void AdicionarVarios()
        {
            Console.Write("\n\tAdicionando varios elementos" +
                          "\nDigite o valor de elementos que deseja adicionar: ");
            var tamanho = int.Parse(Console.ReadLine());
            int[] ListaAuxiliar = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o elemento {i + 1} : ");
                ListaAuxiliar[i] = int.Parse(Console.ReadLine());
            }
            obj.AdicionarVarios(ListaAuxiliar);
        }

        private static void RemoverElemento()
        {
            Console.Write("\n\tRemovendo um elemento" +
                          "\nDigite o valor desejado: ");
            var valorRemovido = int.Parse(Console.ReadLine());
            obj.Remover(valorRemovido);
        }
        private static void PrintarLista()
        {
            foreach (var item in obj.ListaDeInteiros)
            {
                Console.WriteLine(item);
            }
        }

    }
}
