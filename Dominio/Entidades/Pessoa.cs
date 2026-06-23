using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Enumeradores.Enumeradores;

namespace Dominio.Entidades
{
    public abstract class Pessoa
    {
        //dados pessoais
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; } = DateTime.Now;
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Genero Genero { get; set; }
        public Escolaridade Escolaridade { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Pessoa() { }
        
    }
}
