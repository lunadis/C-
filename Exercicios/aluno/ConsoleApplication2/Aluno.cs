using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Aluno : Pessoa
    {
        private int matricula;
        private string curso;

        public void cancelarMatricula()
        {
            Console.WriteLine("Matricula cancelada!");
        }
        public int getMatricula()
        {
            return matricula;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public string getCurso()
        {
            return curso;
        }
        public void setCurso(string cusro)
        {
            this.curso = curso;
        }
        public override string ToString()
        {
            return "Aluno{" + "matricula=" + matricula + ",curso=" + curso + '}';
        }
    }
    
}
