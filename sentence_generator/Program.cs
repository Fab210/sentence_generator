using System;
using System.Collections.Generic;

namespace sentence_generator
{
    class Program
    {


        static string GetRandomElement(string[] t)
        {
            string element;
            Random rand = new Random();

            
            int index = rand.Next(t.Length);
            element = t[index];
            

            return element;
        }



        static void Main(string[] args)
        {
           

            // sujet verbe complement
            var sujets = new string[]
            {
                "Un lapin",
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fee",
                "Un magicien",
                "Une tortue",

            };

            var verbes = new string[]
            {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "regarde",
                "avale",
                "néttoie",
                "se bat avec",
                "s'accroche à",

            };

            var complements = new string[]
            {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "un serpent",
                "une carte",
                "une girafe",
                "le ciel",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapaud",
            };

            

             int NB_Phrases = 100;

            List<string> uniqueGeneratedSentence = new List<string>();
            int doubles = 0;

            for (int i = 0; i < NB_Phrases; i++)
            {
                var sujet = GetRandomElement(sujets);

                var verbe = GetRandomElement(verbes);

                var complement = GetRandomElement(complements);

                var phrase = sujet + " " + verbe + " " + complement;

                phrase = phrase.Replace("à le", "au");

                if (uniqueGeneratedSentence.Contains(phrase))
                {
                    doubles = doubles+1;
                    NB_Phrases = NB_Phrases+1;
                }
                else
                {
                    uniqueGeneratedSentence.Add(phrase);
                    Console.WriteLine("Random phrase : " + phrase);
                }
                

               

                
            }
            Console.WriteLine("________________________________________________________ ");
            Console.WriteLine(" ");
            Console.WriteLine("Doublons empecher : " + doubles);
            Console.WriteLine(" ");
            Console.WriteLine("Nombre de phrases unique : " + uniqueGeneratedSentence.Count);


        }
    }
}
