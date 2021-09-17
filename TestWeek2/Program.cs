using System;
using System.Collections.Generic;
using static TestWeek2.PerishableGood;

namespace TestWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Istanze
            Warehouse<Good> myWarehouse = new Warehouse<Good>();
            myWarehouse.ID = "001";
            myWarehouse.Indirizzo = "Via Roma 12";
            myWarehouse.ImportoTotaleMerciInGiacenza = 0;
            myWarehouse.DataUltimaOperazione = new DateTime(2021, 09, 06);

            ElectronicGood frigo = new ElectronicGood("01", "Frigorifero", 129, DateTime.Now, 0, "Whirlpool");
            PerishableGood pesce = new PerishableGood("02", "Orata", 9, DateTime.Now, 0, new DateTime(2022, 09, 17), PerishableGood.ModalitaDiConservazione.Freezer);
            SpiritDrinkGood gin = new SpiritDrinkGood("03", "London Dry Gin", 12, DateTime.Now, 0, SpiritDrinkGood.TipoB.Gin, 37.5);
            ElectronicGood condizionatore = new ElectronicGood("04", "Condizionatore", 349, DateTime.Now, 0, "Samsung");
            PerishableGood patatine = new PerishableGood("05", "Patatine San Carlo", 1.5, DateTime.Now, 0, new DateTime(2022, 05, 01), ModalitaDiConservazione.Shelf);
            PerishableGood cocaCola = new PerishableGood("06", "Coca-Cola", 2.1, DateTime.Now, 0, new DateTime(2024, 01, 01), ModalitaDiConservazione.Shelf);
            PerishableGood formaggio = new PerishableGood("07", "Emmental", 4.5, DateTime.Now, 0, new DateTime(2021, 09, 28), ModalitaDiConservazione.Fridge);
            SpiritDrinkGood birra = new SpiritDrinkGood("08", "Birra Ichnusa", 1.3, DateTime.Now, 0, SpiritDrinkGood.TipoB.Other, 4.7);
            ElectronicGood frullatore = new ElectronicGood("09", "Frullatore", 49.9, DateTime.Now, 0, "Imetec");
            #endregion

            #region Aggiunta prodotti a lista

            List<Good> mylist = new List<Good>();

            for(int i = 0; i <= 4; i++)
            {
                mylist = myWarehouse + frigo;
            }

            for (int i = 0; i <= 10; i++)
            {
                mylist = myWarehouse + pesce;
            }

            for (int i = 0; i <= 5; i++)
            {
                mylist = myWarehouse + gin;
            }

            for (int i = 0; i <= 3; i++)
            {
                mylist = myWarehouse + condizionatore;
            }

            for (int i = 0; i <= 15; i++)
            {
                mylist = myWarehouse + patatine;
            }

            for (int i = 0; i <= 10; i++)
            {
                mylist = myWarehouse + cocaCola;
            }

            for (int i = 0; i <= 5; i++)
            {
                mylist = myWarehouse + formaggio;
            }

            for (int i = 0; i <= 20; i++)
            {
                mylist = myWarehouse + birra;
            }

            for (int i = 0; i <= 5; i++)
            {
                mylist = myWarehouse + frullatore;
            }
            #endregion

            #region Input da utente (non implementato)
            //Console.WriteLine("Cosa desideri fare? Premi il numero corrispondente");
            //Console.WriteLine("1. Dettagli del tuo magazzino");
            //Console.WriteLine("2. Inserisci prodotto");
            //Console.WriteLine("3. Rimuovi prodotto");

            //var input = Console.ReadLine();
            //switch (input)
            //{
            //    case "1":
            //        myMagazine.StockList();
            //        break;
            //    case "2":
            //        Console.WriteLine("Scegli la tipologia di prodotto da inserire: ");
            //        Console.WriteLine("1. Elettronica");
            //        Console.WriteLine("2. Prodotti deperibili");
            //        Console.WriteLine("3. Alcolici");
            //        var input2 = Console.ReadLine();
            //        switch (input2)
            //        {
            //            case "1":
            //                Console.Write("Inserisci codice merce: ");
            //                string CodiceMerceEG = Console.ReadLine();
            //                Console.Write("Inserisci descrizione: ");
            //                string DescrizioneEG = Console.ReadLine();
            //                Console.Write("Inserisci prezzo: ");
            //                double PrezzoEG = double.Parse(Console.ReadLine());
            //                Console.Write("Inserisci produttore: ");
            //                string ProduttoreEG = Console.ReadLine();
            //                mylist = myMagazine + new ElectronicGood { CodiceMerce = CodiceMerceEG, Descrizione = DescrizioneEG, Prezzo = PrezzoEG, DataDiRicevimento = DateTime.Now, QuantitaInGiacenza = 1, Produttore = ProduttoreEG };
            //                break;
            //            case "2":
            //                Console.Write("Inserisci codice merce: ");
            //                string CodiceMercePG = Console.ReadLine();
            //                Console.Write("Inserisci descrizione: ");
            //                string DescrizionePG = Console.ReadLine();
            //                Console.Write("Inserisci prezzo: ");
            //                double PrezzoPG = double.Parse(Console.ReadLine());
            //                Console.Write("Inserisci data di scadenza (MM DD YYYY): ");
            //                DateTime ScadenzaPG = DateTime.Parse(Console.ReadLine());
            //                Console.WriteLine("Scegli tipo di conservazione:");
            //                Console.WriteLine("1. Freezer");
            //                Console.WriteLine("2. Fridge");
            //                Console.WriteLine("3. Shelf");
            //                var input3 = Console.ReadLine();
            //                switch (input3)
            //                {
            //                    case "1":
            //                        PerishableGood pg = new(CodiceMercePG, DescrizionePG, PrezzoPG, DateTime.Now, 1, ScadenzaPG, ModalitaDiConservazione.Freezer);
            //                        mylist = myMagazine + pg;
            //                        break;
            //                    case "2":
            //                        PerishableGood pg = new(CodiceMercePG, DescrizionePG, PrezzoPG, DateTime.Now, 1, ScadenzaPG, ModalitaDiConservazione.Fridge);
            //                        mylist = myMagazine + pg;
            //                        break;
            //                }
            //                break;
            //        }
            //        break;
            //}
            #endregion

            myWarehouse.StockList();

            //prove di rimozione
            mylist = myWarehouse - pesce;
            mylist = myWarehouse - cocaCola;

            myWarehouse.StockList();
        }
    }
}
