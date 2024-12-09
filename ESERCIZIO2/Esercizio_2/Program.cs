using System;
using System.Collections.Generic;

public class Giocattolo{
    public string Nome{get; private set;}
    public string Materiale{get; private set;}
    public decimal CostoProduzione{get; private set;}
    public decimal PrezzoVendita{get; private set;}

    public Giocattolo(string nome, string materiale, decimal costoproduzione, decimal prezzovendita){
        Nome = nome;
        Materiale = materiale;
        CostoProduzione = costoproduzione;
        PrezzoVendita = prezzovendita;
    }
}

public class Fabbrica{
    private List<Giocattolo> listag = new List<Giocattolo>();

    public void addGiocattolo(Giocattolo g){
        listag.Add(g);
    }

    public void printGiocattolo(){
        for(int i=0; i<listag.Count(); i++){
            Console.WriteLine($"Nome: {listag[i].Nome}, \nMateriale: {listag[i].Materiale}, \nPrezzo Vendita: {listag[i].PrezzoVendita}");
        }
    }

    public decimal calcoloTotale(){
        decimal somma = 0;
        for(int i=0; i<listag.Count(); i++){
            decimal margine = listag[i].PrezzoVendita - listag[i].CostoProduzione;
            somma = somma + margine;
        }
        return somma;
    }

    public class Program{
        public static void Main(){
            Fabbrica Hamleys = new Fabbrica();
            Hamleys.addGiocattolo(new Giocattolo("Teddy Bear", "Peluche", 3.00m, 7.50m));
            Hamleys.addGiocattolo(new Giocattolo("Puzzle", "Cartone", 1.50m, 4.00m));
            Console.WriteLine("Elenco Giocattoli:");
            Hamleys.printGiocattolo();
            Console.WriteLine();
            Console.WriteLine($"Guadagno Totale: {Hamleys.calcoloTotale}");
        }
    }
}