using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoArray
{
    /// <summary>
    /// Lista de inteiros
    /// </summary>
    public class ListaDeInteiros
    {
        private int QuatidadeDeElementos;
        /// <summary>
        /// Lista de números inteiros
        /// </summary>
        public int[] listaDeInteiros;
        /// <summary>
        /// Construtor que recebe o tamanho da lista
        /// </summary>
        /// <param name="tamanhoInicial">Tamanho incial da lista</param>
        public ListaDeInteiros(int tamanhoInicial = 10)
        {
            listaDeInteiros = new int[tamanhoInicial];
            QuatidadeDeElementos = 0;
        }
        /// <summary>
        /// Adiciona um novo numero a lista
        /// </summary>
        /// <param name="elemento">Novo numero</param>
        public void Adicionar(int elemento)
        {
            VerificarCapacidadeLista(QuatidadeDeElementos + 1);
            listaDeInteiros[this.QuatidadeDeElementos] = elemento;
            QuatidadeDeElementos++;
        }
        private void VerificarCapacidadeLista(int tamanhoNecessario)
        {
            int novoTamanho;
            if (tamanhoNecessario < listaDeInteiros.Length)
            {
                return;
            }

            novoTamanho = listaDeInteiros.Length * 2;
            if (tamanhoNecessario > novoTamanho)
            {
                novoTamanho = tamanhoNecessario;
            }

            int[] listaParaAumentarTamanho = new int[novoTamanho];

            for (int indice = 0; indice < this.QuatidadeDeElementos; indice++)
            {
                listaParaAumentarTamanho[indice] = listaDeInteiros[indice];
            }

            this.listaDeInteiros = listaParaAumentarTamanho;

        }
        /// <summary>
        /// Adiciona um array de inteiros na lista de inteiros
        /// </summary>
        /// <param name="ListaAuxiliar">Array de inteiros</param>
        public void AdicionarVarios(int[] ListaAuxiliar){
            VerificarCapacidadeLista(ListaAuxiliar.Length + this.QuatidadeDeElementos);
            for(int i = QuatidadeDeElementos, i2 = 0; i < ListaAuxiliar.Length+QuatidadeDeElementos; i++, i2++)
            {
                listaDeInteiros[i] = ListaAuxiliar[i2];
            }
        }
        /// <summary>
        /// Remove um numero da lista
        /// </summary>
        /// <param name="elementoRemovido">Elemento a ser removido</param>
        public void Remover(int elementoRemovido)
        {
            for (int i = 0; i < this.QuatidadeDeElementos; i++)
            {
                if (this.listaDeInteiros[i] == elementoRemovido)
                {
                    int aux;
                    aux = this.listaDeInteiros[i];
                    this.listaDeInteiros[i] = this.listaDeInteiros[i + 1];
                    this.listaDeInteiros[i + 1] = aux;
                }
            }
            this.listaDeInteiros[QuatidadeDeElementos] = 0;
            QuatidadeDeElementos--;
        }
        /// <summary>
        /// Indexador da lista de inteiros
        /// </summary>
        /// <param name="indice">Recebe um indice de um elemento</param>
        /// <returns>Retorna o elemento no indice</returns>
        public int this[int indice]
        {
            get
            {
                return listaDeInteiros[indice];
            }
            
        }
    }
}
