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
    /// <param name="veiculo"></param>
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
    /// <param name="veic"></param>
    /// <returns></returns>
    public async Task<Veiculo> UpdateVeiculoAsync(Veiculo veic)
    {
        try
        {
            var productExist = dbContext.Veiculo.FirstOrDefault(p => p.Id == veic.Id);
            if (productExist != null)
            {
                dbContext.Update(veic);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return veic;
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

    /// <summary>
    /// Filters vehicles by color asynchronously.
    /// </summary>
    /// <param name="cor">The color to filter by.</param>
    /// <returns>A list of vehicles matching the specified color, or null if no vehicles are found.</returns>
    public async Task<List<Veiculo>?> FiltrarPorCorAsync(string cor)
    {
        try
        {
            var data = await dbContext.Veiculo.Where(v => EF.Functions.Like(v.Cor, cor)).ToListAsync();
            return (data == null) ? (List<Veiculo>?)null : data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while filtering vehicles by color: {ex.Message}");
            return null;
        }
    }


    /// <summary>
    /// Searches for a vehicle by its license plate asynchronously.
    /// </summary>
    /// <param name="placa">The license plate to search for.</param>
    /// <returns>The found vehicle or null if not found.</returns>
    public async Task<List<Veiculo>?> PesquisarPorPlacaAsync(string placa)
    {
        try
        {
            var data = await dbContext.Veiculo.Where(v => EF.Functions.Like(v.Placa, placa)).ToListAsync();
            return (data == null) ? (List<Veiculo>)null : data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while filtering vehicles by color: {ex.Message}");
            return null;
        }
    }


    #endregion
}