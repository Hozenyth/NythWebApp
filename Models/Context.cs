using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NythWebApp.Models
{
    public class Context : DbContext  //interface do EntityFramework chamada DBcontext
    {
        public DbSet<Categoria> Categorias { get; set; } //Uma tabela chamada Categorias

        public DbSet<Produto> Produtos { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Método responsável por configurar o Entity Framework
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NythWebApp;Trusted_Connection=True;");// coloca a string de conexão. 
        }

        public void SetModified(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
