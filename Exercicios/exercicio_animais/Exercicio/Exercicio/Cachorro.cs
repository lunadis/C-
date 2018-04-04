using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    class Cachorro : mamifero
    {
        public void enterrarOsso()
        {
            Console.Write("Enterrando Osso!\n");
        }
        public void abanarRabo()
        {
            Console.Write("\nAbanando rabo!\n");
        }
        public string Reagir(string atitude)
        {
            if ((atitude == "brincar") || (atitude == "acariciar"))
            {
                Console.Write("Abana o rabo");
            }
            else
            {
                Console.Write("Rosna");
            }
            return atitude;
        }
        public int Reagir(int hora=12){
            if (hora > 12)
            {
                Console.Write("Abana o rabo e late");
            }
            if (hora >= 18)
            {
                Console.Write("Não liga para o dono");
            }
            else {
                Console.Write("Abana o rabo");
            }
            return hora;
        }

        public Boolean Reagir(Boolean dono) {
            if (dono == true)
            {
                Console.Write("Abana o rabo e brinca");
            }
            else {
                Console.Write("Avança e ROSNA");
            }
            return dono;
        }

    }
}