using System;
using System.Collections.Generic;

// Classe astratta in cui inizializzeremo il metodo CalcolaGuadagno
abstract class ProdottoSoftware
{
    protected string Nome { get; set; }
    protected decimal PrezzoVendita { get; set; }

    public ProdottoSoftware(string nome, decimal prezzoVendita)
    {
        Nome = nome;
        PrezzoVendita = prezzoVendita;
    }

    // Metodo astratto che andremo ad implementare in WebApp
    public abstract decimal CalcolaGuadagno();
}

class WebApp : ProdottoSoftware
{
    private decimal CostiServer { get; set; }
    private int NumeroUtenti { get; set; }

    public WebApp(string nome, decimal prezzoVendita, decimal costiServer, int numeroUtenti)
        : base(nome, prezzoVendita)
    {
        CostiServer = costiServer;
        NumeroUtenti = numeroUtenti;
    }

    public override decimal CalcolaGuadagno()
    {
        return (PrezzoVendita * NumeroUtenti) - CostiServer;
    }
}
class MobileApp : ProdottoSoftware
{
    private decimal CostiStore { get; set; }
    private int DownloadTotali { get; set; }

    public MobileApp(string nome, decimal prezzoVendita, decimal costiStore, int downloadTotali)
        : base(nome, prezzoVendita)
    {
        CostiStore = costiStore;
        DownloadTotali = downloadTotali;
    }

    public override decimal CalcolaGuadagno()
    {
        return (PrezzoVendita * DownloadTotali) - CostiStore;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<ProdottoSoftware> prodotti = new List<ProdottoSoftware>
        {
            new WebApp("WebApp", 150.00m, 2000.00m, 20),
            new MobileApp("MobileApp E-Commerce", 5.00m, 1000.00m, 500)
        };

        decimal guadagnoTotale = 0;

        foreach (var prodotto in prodotti)
        {
            guadagnoTotale += prodotto.CalcolaGuadagno();
        }

        Console.WriteLine($"Guadagno totale: {guadagnoTotale:C}");
    }
}