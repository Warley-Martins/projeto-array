using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoArray
{
    /// <summary>
    /// Lista de objetos generica
    /// </summary>
    /// <typeparam name="T">Classe generica</typeparam>
    public class ListaDeObjetosGenerica<T>
    {

        private int QuatidadeDeElementos;
        public T[] ListaGenerica;
        /// <summary>
        /// Construtor com argumento opcional
        /// </summary>
        /// <param name="tamanhoInicial">Tamanho da lista</param>
        public ListaDeObjetosGenerica(int tamanhoInicial = 1)
        {
            ListaGenerica = new T[tamanhoInicial];
            QuatidadeDeElementos = 0;
        }

        /// <summary>
        /// Adiciona um novo elemento na lista
        /// </summary>
        /// <param name="elemento">Elemento do tipo da lista</param>
        /// <exception cref="NullReferenceException">O parametro: <paramref name="elemento"/>, não possui referência definida!</exception>
        public void Adicionar(T elemento)
        {
            if (elemento == null)
            {
                throw new NullReferenceException();
            }
            VerificarCapacidadeLista(QuatidadeDeElementos + 1);
            ListaGenerica[this.QuatidadeDeElementos] = elemento;
            QuatidadeDeElementos++;
        }
        private void VerificarCapacidadeLista(int tamanhoNecessario)
        {
            int novoTamanho;
            if (tamanhoNecessario < ListaGenerica.Length)
            {
                return;
            }

            novoTamanho = ListaGenerica.Length * 2;
            if (tamanhoNecessario > novoTamanho)
            {
                novoTamanho = tamanhoNecessario;
            }

            T[] listaParaAumentarTamanho = new T[novoTamanho];

            for (int indice = 0; indice < this.QuatidadeDeElementos; indice++)
            {
                listaParaAumentarTamanho[indice] = ListaGenerica[indice];
            }

            this.ListaGenerica = listaParaAumentarTamanho;

        }
        /// <summary>
        /// Adiciona dois ou mais elementos a uma lista
        /// </summary>
        /// <param name="ListaAuxiliar">Lista de elementos a serem adicionados</param>
        ///<exception cref="NullReferenceException">A Lista: <paramref name="ListaAuxiliar"/>, não possui referência definida!</exception>
        ///<exception cref="NullReferenceException">A Lista: <paramref name="ListaAuxiliar"/>, não possui argumentos válidos definidos!</exception>
        public void AdicionarVarios(T[] ListaAuxiliar)
        {
            if(ListaAuxiliar == null)
            {
                throw new NullReferenceException("Referência não definida");
            }
            if(ListaAuxiliar[0] == null)
            {
                throw new NullReferenceException("Lista com referências não definidas");
            }
            VerificarCapacidadeLista(ListaAuxiliar.Length + this.QuatidadeDeElementos);
            var i = QuatidadeDeElementos;
            foreach (var item in ListaAuxiliar)
            {
                this.ListaGenerica[i] = item;
                i++;
            }
        }
        /// <summary>
        /// Remove um elemento da lista
        /// </summary>
        /// <param name="elementoRemovido">Elemento a ser removido</param>
        /// <exception cref="NullReferenceException">O parametro: <paramref name="elementoRemovido"/>,  não possui referência definida!</exception>
        public void Remover(T elementoRemovido)
        {
            if(elementoRemovido == null)
            {
                throw new NullReferenceException("Referência não definida");
            }
            for (int i = 0; i < ListaGenerica.Length; i++)
            {
                if (this.ListaGenerica[i].Equals(elementoRemovido) && i < (ListaGenerica.Length - 1))
                {
                    T aux;
                    aux = this.ListaGenerica[i];
                    this.ListaGenerica[i] = this.ListaGenerica[i + 1];
                    this.ListaGenerica[i + 1] = aux;
                    Console.WriteLine($"aux : {aux}\ni : {ListaGenerica[i]}\n i+1 : {ListaGenerica[i+1]}");
                }
            }
            QuatidadeDeElementos--;
        }
        private T GetListaDeInteirosIndice(int i)
        {
            return ListaGenerica[i];
        }
        /// <summary>
        /// Indexador da lista Generica
        /// </summary>
        /// <param name="indice">Posição do elemento</param>
        /// <returns>Retorna o elemento no inidce</returns>
        public T this[int indice]
        {
            get
            {
                return GetListaDeInteirosIndice(indice);
            }

        }

    }
}
