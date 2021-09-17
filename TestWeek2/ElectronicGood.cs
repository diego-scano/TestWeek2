using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    public class ElectronicGood : Good
    {
        public string Produttore { get; set; }
        public ElectronicGood(string codiceMerce, string descrizione, double prezzo, DateTime dataDiRicevimento, int quantitaInGiacenza, string produttore)
        {
            CodiceMerce = codiceMerce;
            Descrizione = descrizione;
            Prezzo = prezzo;
            DataDiRicevimento = dataDiRicevimento;
            QuantitaInGiacenza = quantitaInGiacenza;
            Produttore = produttore;
        }

        public override string ToString()
        {
            return $"Codice merce: {CodiceMerce}\nDescrizione: {Descrizione}\nPrezzo: {Prezzo} $\nData di ricevimento: {DataDiRicevimento}\nQuantità in giacenza: {QuantitaInGiacenza}\nProduttore: {Produttore}";
        }
    }
}
