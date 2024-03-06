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

static void LoadData()
{
    if (File.Exists("C:\\4AD\\SWP\\20240606\\Lagerverwaltung\\Lagerverwaltung\\bin\\Debug"))
    {
        string[] lines = File.ReadAllLines(dataFilePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            string name = parts[0];
            string description = parts[1];
            double price = double.Parse(parts[2]);
            int stock = int.Parse(parts[3]);

            Article article = new Article(name, description, price, stock);
            articles.Add(article);
        }
    }
}


