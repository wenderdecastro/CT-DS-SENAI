using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produtos
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            Cadastrar();
        }

        public void Cadastrar()
        {

            this.Email = "admin";
            this.Senha = "admin";

        }
        public string Deletar(Usuario _usuario)
        {
            return "";
        }
    }
}