using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade5_csharp_senai
{
    public class CachorrosBrabos
    {

        public string nome;
        public string raça;
        public string vulgo;

        public void Morder()
        {
            Console.WriteLine($"O cachorro mordeu a criança.");
        }
        public void Latir()
        {
            Console.WriteLine($"O cachorro latiu.");
        }
        static void Cachorrinhos(string[] args)
        {
            CachorrosBrabos Pinscher = new CachorrosBrabos();

            Pinscher.nome = "Belzebu";
            Pinscher.raça = "Pinscher";
            Pinscher.vulgo = "Demonio";


            CachorrosBrabos Budogue = new CachorrosBrabos();
            Budogue.raça = "Bulldog ingles";
            Budogue.nome = "Fabricio";
            Budogue.vulgo = "Gordão";

            CachorrosBrabos Caramelo = new CachorrosBrabos();
            Caramelo.nome = "Samuel";
            Caramelo.raça = "Vira-Lata";
            Caramelo.vulgo = "Mata-rato";
        }
    }
}
