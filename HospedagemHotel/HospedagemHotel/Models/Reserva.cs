namespace HospedagemHotel.Models;

public class Reserva
{
    private List<Pessoa> Hospedes = new List<Pessoa>();
    private Suite Suite;
    private int DiasReservados;

    public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
    {
        Suite = suite;
        CadastrarHospedes(hospedes);
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        foreach (var hospede in hospedes)
        {
            if (ReservaCheia())
            {
                throw new Exception("A suite atingiu o número máximo de hóspedes");
            }
            Hospedes.Add(hospede);
        }
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        var possuiDesconto = DiasReservados >= 10;
        var valorDiaria = Suite.ValorDiraria * DiasReservados;

        if (possuiDesconto) valorDiaria -= valorDiaria / 10;
        
        return valorDiaria;
    }

    private bool ReservaCheia()
    {
        return Suite.Capacidade == Hospedes.Count;
    }
}