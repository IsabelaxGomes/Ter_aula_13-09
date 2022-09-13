using System;

namespace API.Models
{
    // a clase para a tabela no banco de dados 
    public class Funcionario
    {
        public Funcionario () => CriadoEm = DateTime.Now;
        public int Id { get; set; }  //toda classe tem que ter um id
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public string Email {get; set;}
        public DateTime Nascimento { get; set; }
        public DateTime CriadoEm { get; set; }

        //se quiser adicionar algo ou atulizar no banco 
    }
}
