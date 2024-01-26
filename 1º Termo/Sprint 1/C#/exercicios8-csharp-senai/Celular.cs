using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade8_csharp_senai
{
    public class Celular
    {

        public string Cor = "Preto";
        public string Modelo = "Xiaomi poco 5";
        public string Tamanho = "162.91 x 76.03 x 7.9 mm";
        public bool Ligado = false;
        public bool Ligar()
        {

            if (Ligado == false)
            {
                Console.WriteLine($"\n\nLigando o celular.");
                Ligado = true;
                return Ligado;
            }
            else
            {
                Console.WriteLine($"\n\nO celular ja está ligado");
                return Ligado;
            }

        }
        public bool Desligar()
        {
            if (Ligado == true)
            {
                Console.WriteLine($"\n\nDesigando o celular.");
                Ligado = false;
                return Ligado;
            }
            else
            {
                Console.WriteLine($"\n\nO celular ja está desligado");
                return Ligado;
            }
        }

        public void fazerChamada()
        {
            if (Ligado == true)
            {
                Console.WriteLine($"\n\nFazendo chamada...");
            }
            else
            {
                Console.WriteLine($"\n\nO celular está desligado, não foi possivel realizar a chamada.");
            }
        }
        public void enviarMensagem()
        {
            if (Ligado == true)
            {
                Console.WriteLine($"\n\nEnviando mensagem...");
            }
            else
            {
                Console.WriteLine($"\n\nO celular está desligado, não foi possivel mandar a mensagem.");
            }
        }
        public void verPropriedades()
        {
            if (Ligado == true)
            {
                Console.WriteLine($"\n\nAs especificações do sistema são: ");
                Console.WriteLine($"O celular é um {this.Modelo} da cor {this.Cor} e mede {this.Tamanho}");
            }
            else
            {
                Console.WriteLine($"\n\nO celular está desligado, não foi possivel acessar as especificações do sistema.");
            }
        }
    }
}