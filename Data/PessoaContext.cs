using Microsoft.EntityFrameworkCore;
using Pessoa.Models;

namespace Pessoa.Data;

public class PessoaContext : DbContext
{
    public DbSet<PessoaModel> Pessoa { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=pessoa.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}