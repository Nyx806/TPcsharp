
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPcsharp2._0;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panier panier = new Panier();
            int ajoutPanier = 0;
            
            List<Produit> produits = new List<Produit>
            {
                new Produit("produit 1", 12, 4, 1),
                new Produit("produit 2", 20, 4, 2),
                new Produit("produit 3", 50, 4, 3),
            };


            while (true)
            {
                Console.Clear(); 



                Console.WriteLine("   #####    #####   ### ###   #####    ######           ######   #######  ### ###  #######  ##  ###   ######  #######\r\n  ### ###  ### ###  ### ###  ### ###   # ## #           ### ###  ### ###  ### ###  ### ###  ### ###   # ## #  ### ###\r\n  ### ###  ###      ### ###  ### ###     ##             ### ###  ###      ### ###  ###      #######     ##    ###\r\n  #######  ###      #######  #######     ##             ######   #####    ### ###  #####    #######     ##    #####\r\n  ### ###  ###      ### ###  ### ###     ##             ### ##   ###      ### ###  ###      ### ###     ##    ###\r\n  ### ###  ### ###  ### ###  ### ###     ##             ### ###  ### ###   #####   ### ###  ### ###     ##    ### ###\r\n  ### ###   #####   ### ###  ### ###     ##             ### ###  #######    ###    #######  ### ###     ##    #######\r\n\r\n");

                foreach (Produit produit in produits)
                {
                    Console.WriteLine(produit);                   
                }

                if (panier != null)
                {
                    panier.afficheContenu();
                }

                Console.Write("entrez le code produit pour l'ajouter au panier ou entrez 999 si vous voulez ajouter un produit : ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out ajoutPanier))
                {
                    Produit produitSelectionner = produits.Find(p => p.CodeProduit == ajoutPanier);

                    if (produitSelectionner.QantiteEnStock > 0)
                    {
                        panier.addProduit(produitSelectionner);
                        produitSelectionner.QantiteEnStock--;
                        panier.totalProduit(produitSelectionner.Prix);
                    }
                    else
                    {
                        Console.WriteLine("cette article à été victime de son succès");
                    }
                }
            }
                
        }
    }
}

