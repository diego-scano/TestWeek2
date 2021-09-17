using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2
{
    public class Warehouse<T> : IEnumerable<T> where T : Good
    {
        #region Proprietà
        public string ID { get; set; }
        public string Indirizzo { get; set; }
        public double ImportoTotaleMerciInGiacenza { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        private List<T> Merci = new List<T>();
        #endregion

        public static List<T> operator +(Warehouse<T> my, T m)
        {
            var doppio = my.Merci.FirstOrDefault(i => i.CodiceMerce == m.CodiceMerce);
            if (doppio == null)
            {
                my.Merci.Add(m);
                my.ImportoTotaleMerciInGiacenza += m.Prezzo;
                my.DataUltimaOperazione = DateTime.Now;
            }
            else
            {
                m.QuantitaInGiacenza += 1;
                my.ImportoTotaleMerciInGiacenza += m.Prezzo;
                my.DataUltimaOperazione = DateTime.Now;
            }

            return my.Merci;
        }

        public static List<T> operator -(Warehouse<T> my, T m)
        {
            var doppio = my.Merci.FirstOrDefault(i => i.CodiceMerce == m.CodiceMerce);
            if (doppio != null)
            {
                if (m.QuantitaInGiacenza == 1)
                {
                    my.Merci.Remove(m);
                    my.ImportoTotaleMerciInGiacenza -= m.Prezzo;
                    my.DataUltimaOperazione = DateTime.Now;
                }
                else if (m.QuantitaInGiacenza > 1)
                {
                    my.ImportoTotaleMerciInGiacenza -= m.Prezzo;
                    my.DataUltimaOperazione = DateTime.Now;
                    m.QuantitaInGiacenza -= 1;
                }
            }
            else
            {
                throw new ArgumentException();
            }
            return my.Merci;
        }

        public void StockList()
        {
            Console.WriteLine("\n=== IL TUO MAGAZZINO ===\n");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Indirizzo: {Indirizzo}");
            Console.WriteLine($"Importo totale merci in giacenza: {Math.Round(ImportoTotaleMerciInGiacenza, 2)}");
            Console.WriteLine($"Data ultima operazione: {DataUltimaOperazione.ToShortDateString()}");

            Console.WriteLine("\n--- Lista merci in magazzino ---");

            
                foreach (var i in Merci)
                {
                        Console.WriteLine("\n----------------------------------");
                        Console.WriteLine($"- Codice merce: {i.CodiceMerce}");
                        Console.WriteLine($"- Descrizione: {i.Descrizione}");
                        Console.WriteLine($"- Prezzo: {i.Prezzo} $");
                        Console.WriteLine($"- Data di ricevimento: {i.DataDiRicevimento.ToShortDateString()}");
                        Console.WriteLine($"- Quantità in giacenza: {i.QuantitaInGiacenza}");                                   
                }
                     
        }

        #region IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var m in Merci)
            {
                yield return m;
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
