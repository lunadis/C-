using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    class Animal
    {
        private float peso;
        private int idade;
        private int membros;


        public virtual void locomover()
        {
           Console.WriteLine("Movendo!");
        }
        public void alimentar()
        {
            Console.WriteLine("Comendo!");
        }
        public void emitirSom()
        {
            Console.WriteLine("Emitindo som!");
        }

        public float getPeso()
        {
            return peso;
        }
        public void setPeso(float peso)
        {
            this.peso = peso;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public int getMembros()
        {
            return membros;
        }
        public void setMembros(int membros)
        {
            this.membros = membros;
        }

        public override string ToString()
        {
            return "Animal{" + "Peso=" + peso + "Idade=" + idade +"membros"+membros+'}';
        }

        }
    }
