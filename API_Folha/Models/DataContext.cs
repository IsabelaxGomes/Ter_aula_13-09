using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    //Entity Framework Code First
    //É a classe que define a estrutura do banco de dados

    public class DataContext : DbContext // tem que ter o DbContext mas temos que ter o using
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options) { }
            //AS opções que /passar/recebo que manda para a classe pai  e o pai vai conectar nao banco 

        //Definir quais as classes de modelo servirão para as         
        //tabelas no banco de dados
        public DbSet<Funcionario> Funcionarios { get; set; }
        // o que está <> é a classe que vai fazer a tabela no banco.

    
    }
}