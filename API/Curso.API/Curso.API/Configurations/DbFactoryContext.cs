using Curso.API.Infraestruture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Curso.API.Configurations
{
    public class DbFactoryContext : IDesignTimeDbContextFactory<CursoDbContext>
    {
        private readonly IConfiguration _configuration;

        //public DbFactoryContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Cursomvc; Integrated Security=True");

            CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);

            return contexto;
        }
    }
}
