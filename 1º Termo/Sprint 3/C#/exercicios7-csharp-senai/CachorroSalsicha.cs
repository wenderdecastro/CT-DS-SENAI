using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade5_csharp_senai
{
    class CachorroSalsicha
    {
        string nome;
        float nota;
        string vulgo;

        public void Dormir()
        {
            Console.WriteLine($"O cachorro dormiu");
        }
        public void DarAPata()
        {
            Console.WriteLine($"O cachorro deu a pata");
        }
        static void Salsichas(string[] args)
        {
            CachorroSalsicha Abrobra = new CachorroSalsicha();

            Abrobra.nome = "Sir Daulshund Abobora Degundo";
            Abrobra.nota = 10;
            Abrobra.vulgo = "Cachorro salsicha que fala abrobra";


            CachorroSalsicha Bencinha = new CachorroSalsicha();
            Bencinha.nome = "Salsicha crente";
            Bencinha.nota = 6.5f;
            Bencinha.vulgo = "Cachorro salsicha que da bença pra vó";

            CachorroSalsicha Proletario = new CachorroSalsicha();
            Abrobra.nome = "Salsicha da silva";
            Abrobra.nota = 10;
            Abrobra.vulgo = "Cachorro salsicha que saca o auxilio emergencial";

            Bencinha.DarAPata();
        }
    }
}
