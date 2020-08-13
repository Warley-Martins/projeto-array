using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoArray
{
    public class ListaDeObjetosGenerica<T>
    {

        private int QuatidadeDeElementos;
        public T[] ListaGenerica;
        public ListaDeObjetosGenerica(int tamanhoInicial = 1)
        {
            ListaGenerica = new T[tamanhoInicial];
            QuatidadeDeElementos = 0;
        }
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
        public void AdicionarVarios(T[] ListaAuxiliar)
        {
            VerificarCapacidadeLista(ListaAuxiliar.Length + this.QuatidadeDeElementos);
            var i = QuatidadeDeElementos;
            foreach (var item in ListaAuxiliar)
            {
                this.ListaGenerica[i] = item;
                i++;
            }
        }
        public void Remover(T elementoRemovido)
        {
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
        public T GetListaDeInteirosIndice(int i)
        {
            return ListaGenerica[i];
        }
        public T this[int indice]
        {
            get
            {
                return GetListaDeInteirosIndice(indice);
            }

        }

    }
}
