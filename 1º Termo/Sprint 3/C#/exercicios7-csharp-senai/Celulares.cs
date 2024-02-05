using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade5_csharp_senai
{
    public class Celulares
    {
        public string vulgo;
        public string modelo;
        public int ram;

        public void Ligar()
        {
            Console.WriteLine($"O celular Ligou");
        }
        public void Travar()
        {
            Console.WriteLine($"O celular travou.");
        }
        static void Main(string[] args)
        {
            Celulares LG = new Celulares();

            LG.vulgo = "trava-trava";
            LG.modelo = "LG K9 Azul";
            LG.ram = 2;


            Celulares Iphone = new Celulares();
            Iphone.vulgo = "Celular de burguês";
            Iphone.modelo = "Iphone 13 Black";
            Iphone.ram = 8;

            Celulares Motorola = new Celulares();
            Motorola.vulgo = "G2 de cria";
            Motorola.modelo = "Moto g2 capa amarela";
            Motorola.ram = 2;

        }
    }
}