using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoArray
{
    public class ListaDeObjetosInt
    {
        private int QuatidadeDeElementos;
        public int[] ListaDeInteiros;
        public ListaDeObjetosInt(int tamanhoInicial = 10)
        {
            ListaDeInteiros = new int[tamanhoInicial];
            QuatidadeDeElementos = 0;
        }
        public void Adicionar(int elemento)
        {
            VerificarCapacidadeLista(QuatidadeDeElementos + 1);
            ListaDeInteiros[this.QuatidadeDeElementos] = elemento;
            QuatidadeDeElementos++;
        }

        private void VerificarCapacidadeLista(int tamanhoNecessario)
        {
            int novoTamanho;
            if (tamanhoNecessario < ListaDeInteiros.Length)
            {
                return;
            }

            novoTamanho = ListaDeInteiros.Length * 2;
            if (tamanhoNecessario > novoTamanho)
            {
                novoTamanho = tamanhoNecessario;
            }

            int[] listaParaAumentarTamanho = new int[novoTamanho];

            for (int indice = 0; indice < this.QuatidadeDeElementos; indice++)
            {
                listaParaAumentarTamanho[indice] = ListaDeInteiros[indice];
            }

            this.ListaDeInteiros = listaParaAumentarTamanho;

        }
        public void AdicionarVarios(int[] ListaAuxiliar){
            VerificarCapacidadeLista(ListaAuxiliar.Length + this.QuatidadeDeElementos);
            for(int i = QuatidadeDeElementos, i2 = 0; i < ListaAuxiliar.Length+QuatidadeDeElementos; i++, i2++)
            {
                ListaDeInteiros[i] = ListaAuxiliar[i2];
            }
        }
        public void Remover(int elementoRemovido)
        {
            for (int i = 0; i < this.QuatidadeDeElementos; i++)
            {
                if (this.ListaDeInteiros[i] == elementoRemovido)
                {
                    int aux;
                    aux = this.ListaDeInteiros[i];
                    this.ListaDeInteiros[i] = this.ListaDeInteiros[i + 1];
                    this.ListaDeInteiros[i + 1] = aux;
                }
            }
            this.ListaDeInteiros[QuatidadeDeElementos] = 0;
            QuatidadeDeElementos--;
        }
        public int this[int indice]
        {
            get
            {
                return ListaDeInteiros[indice];
            }
            
        }
    }
}
