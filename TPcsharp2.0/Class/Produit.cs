using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPcsharp2._0
{
    internal class Produit
    {
        public string Nom;
        public float Prix;
        public int QantiteEnStock;
        public int CodeProduit;

        public Produit(string nom, float prix, int qantiteEnStock, int codeProduit)
        {
            Nom = nom;
            Prix = prix;
            QantiteEnStock = qantiteEnStock;
            CodeProduit = codeProduit;
        }

        public override string ToString()
        {
            return $"Produit : {Nom}, Prix : {Prix}, Quantité : {QantiteEnStock}, Code Produit : {CodeProduit}";
        }

        public void creationProduit()
        {
            string newName;
            float newPrix;
            int newQantiteEnStock;
            int newCodeProduit;

            Console.Write("entrez le nom de votre produit : ");
            newName = Console.ReadLine();

            Console.Write("entrez le prix du produit : ");
            newPrix = Console.Read();

            Console.Write("entrez le nombre de de produit que vous possédez : ");
            newQantiteEnStock = Console.Read();

            Console.Write("choisissez le code produit : ");
            newCodeProduit = Console.Read();

            Console.WriteLine("merci d'avoir enregistrer le produit");

        }
    }
}
