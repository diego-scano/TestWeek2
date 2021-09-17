using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    public class SpiritDrinkGood : Good
    {
        public enum TipoB { Whisky, Vodka, Grappa, Gin, Other }
        public TipoB Tipo { get; set; }
        public double GradazioneAlcoolica { get; set; }

        public SpiritDrinkGood(string codiceMerce, string descrizione, double prezzo, DateTime dataDiRicevimento, int quantitaInGiacenza, TipoB tipo, double gradazioneAlcoolica)
        {
            CodiceMerce = codiceMerce;
            Descrizione = descrizione;
            Prezzo = prezzo;
            DataDiRicevimento = dataDiRicevimento;
            QuantitaInGiacenza = quantitaInGiacenza;
            Tipo = tipo;
            GradazioneAlcoolica = gradazioneAlcoolica;
        }

        public override string ToString()
        {
            return $"Codice merce: {CodiceMerce}\nDescrizione: {Descrizione}\nPrezzo: {Prezzo} $\nData di ricevimento: {DataDiRicevimento}\nQuantità in giacenza: {QuantitaInGiacenza}\nTipo: {Tipo}\nGradazione alcolica: {GradazioneAlcoolica} %";
        }
    }
}
