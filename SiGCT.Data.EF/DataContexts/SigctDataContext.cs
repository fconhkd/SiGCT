using SiGCT.Data.EF.Mappings;
using SiGCT.Models;
using System.Data.Entity;

namespace SiGCT.Data.EF.DataContexts
{
    public class SigctDataContext : DbContext
    {
        public SigctDataContext()
            : base("RastreadorConnectionString")
        {
            Database.SetInitializer<SigctDataContext>(new SigctDataContextInitializer());
            //desabilita o lazy
            Configuration.LazyLoadingEnabled = false;
            // não cria o proxy no modelo
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Conta> Conta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //adiciona os mapeamentos
            modelBuilder.Configurations.Add(new ContaMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class SigctDataContextInitializer : DropCreateDatabaseIfModelChanges<SigctDataContext>
    {
        protected override void Seed(SigctDataContext context)
        {
            // tabelas e conteudos que devem existir no banco no deploy
            //empresas
            //var log = context.Empresas.Add(new Empresa() { Nome = "LOG", Codigo = "102", Filiais = new List<Filial>/() });
            //context.SaveChanges();
            //
            //base.Seed(context);
        }
    }
}
