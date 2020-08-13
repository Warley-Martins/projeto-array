using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoArray
{
     public class Teste
    {
        public string Nome { get; set; }

        public Teste(string nome)
        {
            this.Nome = nome;
        }


        public override string ToString()
        {
            return $"Nome: {this.Nome}";
        }

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
