namespace CRUD.Data;
using Microsoft.EntityFrameworkCore;

public class VeiculoService
{
    #region Métodos privados
    private VeiculoDbContext dbContext;
    #endregion

    #region Construtor
    public VeiculoService(VeiculoDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion

    #region Metodos Publicos 
    /// <summary>
    /// Retorna a lista de Veiculos
    /// </summary>
    /// <returns></returns>
    public async Task<List<Veiculo>> RetornaVeiculoAsync()
    {
        return await dbContext.Veiculo.ToListAsync();
    }

    /// <summary>
    /// Adiciona um novo Veiculo para DbContext e o salva
    /// </summary>
    /// <param name="prod"></param>
    /// <returns></returns>
    public async Task<Veiculo> AddVeiculoAsync(Veiculo veiculo)
    {
        try
        {
            dbContext.Veiculo.Add(veiculo);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return veiculo;
    }

    /// <summary>
    /// Atualiza um Veiculo e salva as mudanças
    /// </summary>
    /// <param name="prod"></param>
    /// <returns></returns>
    public async Task<Veiculo> UpdateVeiculoAsync(Veiculo prod)
    {
        try
        {
            var productExist = dbContext.Veiculo.FirstOrDefault(p => p.Id == prod.Id);
            if (productExist != null)
            {
                dbContext.Update(prod);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return prod;
    }

    /// <summary>
    /// Remove um Veiculo de DbContext e o salva
    /// </summary>
    /// <param name="Veiculo"></param>
    /// <returns></returns>
    public async Task DeleteVeiculoAsync(Veiculo veiculo)
    {
        try
        {
            dbContext.Veiculo.Remove(veiculo);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}