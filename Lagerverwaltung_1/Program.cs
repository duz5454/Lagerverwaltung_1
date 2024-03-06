using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

class Program
{
    static List<Article> articles = new List<Article>();
    static string dataFilePath = "articles.txt";

    static void Main(string[] args)
    {
        LoadData();

        while (true)
        {
            Console.WriteLine("Lagerverwaltungsanwendung");
            Console.WriteLine("1. Artikel hinzufügen");
            Console.WriteLine("2. Artikel suchen");
            Console.WriteLine("3. Bestand anzeigen");
            Console.WriteLine("4. Artikel verkaufen");
            Console.WriteLine("5. Artikel löschen");
            Console.WriteLine("6. Beenden");

            Console.Write("Wählen Sie eine Option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddArticle();
                    break;
                case 2:
                    SearchArticle();
                    break;
                case 3:
                    DisplayStock();
                    break;
                case 4:
                    SellArticle();
                    break;
                case 5:
                    DeleteArticle();
                    break;
                case 6:
                    SaveData();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ungültige Option. Bitte wählen Sie erneut.");
                    break;
            }
        }
    }
}
