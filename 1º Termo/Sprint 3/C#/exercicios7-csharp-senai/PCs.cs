using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade5_csharp_senai
{
    public class Pcs
    {

        public string vulgo;

        public string placaDeVideo;

        public string processador;

        public void Ligar()
        {
            Console.WriteLine($"O computador Ligou.");
        }
        public void Desligar()
        {
            Console.WriteLine($"O computador desligou.");
        }
        static void Computadores(string[] args)
        {
            Pcs Pobre = new Pcs();

            Pobre.vulgo = "Maquinha de solda";
            Pobre.placaDeVideo = "gt 310";
            Pobre.processador = "só deus sabe";


            Pcs Medio = new Pcs();
            Medio.vulgo = "Da pro gasto";
            Medio.placaDeVideo = "gtx 1650";
            Medio.processador = "r5 3600x";

            Pcs Gamer = new Pcs();
            Gamer.vulgo = "Pc de 20k";
            Gamer.placaDeVideo = "RTX 3070ti";
            Gamer.processador = "i7 13700k";

        }

    }
}