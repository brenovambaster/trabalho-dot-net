using CRUD.Data; //seu namespace
namespace CRUD.Shared; //seu namespace
public class StateContainer
{
    public Veiculo? veiculo { get; set; }
    public void AtualizaVeiculo(Veiculo veiculo)
    {
        this.veiculo = veiculo;
    }
}