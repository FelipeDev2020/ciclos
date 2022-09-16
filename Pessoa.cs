using System;
using System.Collections.Generic;
using System.Text;

namespace ciclos {
    class Pessoa {
        //Atribudos ou campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        public void Mostrar() {
            Console.WriteLine( string.Format($"Meu nome é {nome} {sobrenome} e meu ano de nascimento é {anoNascimento}"));
        }

        public void Somar(int num1, int num2) {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar(String nome, int idade) {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos");
        }
    }
}
