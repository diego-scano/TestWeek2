using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    public class PerishableGood : Good
    {
        public DateTime DataDiScadenza { get; set; }
        public enum ModalitaDiConservazione { Freezer, Fridge, Shelf }
        public ModalitaDiConservazione Conservazione { get; set; }
        public PerishableGood(string codiceMerce, string descrizione, double prezzo, DateTime dataDiRicevimento, int quantitaInGiacenza, DateTime dataDiScadenza, ModalitaDiConservazione conservazione)
        {
            CodiceMerce = codiceMerce;
            Descrizione = descrizione;
            Prezzo = prezzo;
            DataDiRicevimento = dataDiRicevimento;
            QuantitaInGiacenza = quantitaInGiacenza;
            DataDiScadenza = dataDiScadenza;
            Conservazione = conservazione;
        }

        public override string ToString()
        {
            return $"Codice merce: {CodiceMerce}\nDescrizione: {Descrizione}\nPrezzo: {Prezzo} $\nData di ricevimento: {DataDiRicevimento}\nQuantità in giacenza: {QuantitaInGiacenza}\nData di scadenza: {DataDiScadenza.ToShortDateString()}\nModalità di conservazione: {Conservazione}";
        }
    }
}
