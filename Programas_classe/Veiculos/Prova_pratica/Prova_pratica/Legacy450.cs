using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova_pratica
{
    class Legacy450 : Aeronave
    {
        public override void locomover()
        {
            Console.Write("\nLocomovendo \n usando TURBINA\n");
        }
        public override void abastecer()
        {
            Console.Write("\nAbastecendo: Querosene\n");
        }


        public string decolar(string clima) {
            if (clima == "sol") {
                Console.Write("clima:" + clima + "\nVoo normal\n");
            }
            if (clima == "chuva e nublado")
            {
                Console.Write("clima:"+ clima + "\nVoo por instrumentos\n");
            }
            else {
                if (clima == "neve") {
                    Console.Write("clima:" + clima + "\nVoo cancelado\n");
                }
            }
            return clima;
        }

        public int decolar(int horario) {
            if (horario >= 1 && horario <= 12) {
                Console.Write("\nVoo Matutino: Altitude mais alta\n");
            }
            if (horario > 12 && horario <= 18)
            {
                Console.Write("\nVoo Vespertino: altitude média\n");
            }
            if (horario > 18 && horario < 1)
            {
                Console.Write("\nVoo noturno: Altitude mais baixa\n");
            }
            return horario;
        }
        public Boolean decolar(Boolean tipo) {
            if (tipo == true) {
                Console.Write("Passegeiros: Sim \n Servir refeição");
            }
            else{
                Console.Write("Passageitos: Não \n amarrar bem a carga");
            }
            return tipo;
        }

    }
}
