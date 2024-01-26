using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade5_csharp_senai
{
    public class CarrosBrabos
    {

        public string nome;
        public string cor;
        public string vulgo;
        public string corRoda;
        public float porcentagemInsulfilm;


        public void Acelerar()
        {
            Console.WriteLine($"O carro acelerou.");
        }
        public void Freiar()
        {
            Console.WriteLine($"O carro freiou.");
        }
        public void Capotar()
        {
            Console.WriteLine($"O carro capotou.");
        }
        public void Carros(string[] args)
        {
            CarrosBrabos monzaTubarao = new CarrosBrabos();

            monzaTubarao.nome = "Monzinha do marcão";
            monzaTubarao.cor = "Cinza Azulado";
            monzaTubarao.corRoda = "prata";
            monzaTubarao.porcentagemInsulfilm = 0; //nao possui (vidro quebrado)
            monzaTubarao.vulgo = "carro de velho que joga no 50tão";

            CarrosBrabos uninho94 = new CarrosBrabos();
            uninho94.nome = "Cintia";
            uninho94.cor = "preto";
            uninho94.corRoda = "prata";
            uninho94.porcentagemInsulfilm = 100; //blackout, ilegal
            uninho94.vulgo = "Carro de sequestro";

            CarrosBrabos golBola2006 = new CarrosBrabos();
            golBola2006.nome = "Gol 2006";
            golBola2006.cor = "prata";
            golBola2006.corRoda = "prata";
            golBola2006.porcentagemInsulfilm = 20;
            golBola2006.vulgo = "gol da firma";
        }
    }
}