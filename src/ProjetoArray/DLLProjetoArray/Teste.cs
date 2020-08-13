using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoArray
{
    /// <summary>
    /// Classe Teste do programa
    /// </summary>
     public class Teste
    {
        /// <summary>
        /// Propriedade do objeto de tipo Teste
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="nome">Nome do objeto</param>
        /// <exception cref="ArgumentException">No argumento: <paramref name="nome"/>, a referência não pode ser nula ou vazia</exception>
        public Teste(string nome)
        {
            if(String.IsNullOrEmpty(nome))
            {
                
                throw new ArgumentException("O argumento passado está nulo ou vazio", nameof(nome));
            }
            this.Nome = nome;
        }

        /// <summary>
        /// retorna as caracteriscas do objeto
        /// </summary>
        /// <returns>Retorna uma string com as caracteristicas do objeto</returns>
        public override string ToString()
        {
            return $"Nome: {this.Nome}";
        }

        /// <summary>
        /// Compara dois objetos do tipo Teste
        /// </summary>
        /// <param name="obj">Objeto do tipo Teste a ser comparado</param>
        /// <returns>Retorna o valor logico da comparação</returns>
        public override bool Equals(object obj)
        {
            var teste = obj as Teste;
            if(teste == null)
            {
                return false;
            }

            return this.Nome == teste.Nome;
        }
    }
}
