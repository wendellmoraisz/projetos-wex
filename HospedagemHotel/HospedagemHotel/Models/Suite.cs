namespace HospedagemHotel.Models;

public class Suite
{
    public string TipoSuite { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDiraria { get; set; }

    public Suite(string tipoSuite, int capacidade, decimal valorDiraria)
    {
        TipoSuite = tipoSuite;
        Capacidade = capacidade;
        ValorDiraria = valorDiraria;
    }
}