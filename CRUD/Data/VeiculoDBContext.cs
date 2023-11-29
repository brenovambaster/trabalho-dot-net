/// <summary>
/// Uma classe que herda "DbContext" para interagir e realizar operações de banco de dados. 
/// A classe também substitui o método OnModelCreating() para que o banco de dados possa ter alguns dados iniciais (seed data) para fins de teste.
/// </summary>
/// 

namespace CRUD.Data;
using Microsoft.EntityFrameworkCore;


public class VeiculoDbContext : DbContext
{
    #region Construtor
    public VeiculoDbContext(DbContextOptions<VeiculoDbContext> options) : base(options)
    {

    }
    #endregion

    #region Propriedades
    public DbSet<Veiculo> Veiculo { get; set; }
    #endregion

    #region Métodos sobrecarregados
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Veiculo>().HasData(RetornaVeiculos());
        base.OnModelCreating(modelBuilder);
    }
    #endregion


    #region Métodos privados
    private List<Veiculo> RetornaVeiculos()
    {
        return new List<Veiculo>{
        new Veiculo { Id = 1001, Placa="ABC-1234",Chassi = "12345678901234567",Cor = "Azul",Modelo = "Fusca",Ano_fabricacao = "10-12-2201" },
        new Veiculo { Id = 1002, Placa="CDC-3213", Chassi="1241234kc21c243c421", Cor="Vermelho", Modelo="Fusca", Ano_fabricacao = "10-12-2201"},
        new Veiculo { Id = 1003, Placa="PUB-3213", Chassi="124134kc24421", Cor="Prata", Modelo="Hilux 2.0", Ano_fabricacao = "10-12-2201"},
        new Veiculo { Id = 1004, Placa="PWD-2313", Chassi="1241234kc21c243c421", Cor="Vermelho", Modelo="Corola", Ano_fabricacao = "10-12-2201" }
    };
    }
    #endregion
}