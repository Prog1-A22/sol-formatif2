namespace SolFormatif2A22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // La question 4 est un programme alors je la fais ici
            // J'ajoute des méthodes au besoin avec le préfixe q4
            // ex: q4_calculerMoyenne
            int note = 0;
            int nbEleve = 0;
            double moyenne = 0.0;
            int echec = 0;

            while (note >= 0)
            {
                Console.Clear(); // pas obligatoire, c'est pour faire moins laid

                Console.WriteLine("Entrer les résulats des étudiants\n Entrer un nombre négatif quand c'est fini");
                // 4.1 On ne vérifie pas si la personne a bien entré la donnée
                Console.WriteLine("Prochain résultat : ");
                int.TryParse(Console.ReadLine(), out note);
                // 4.2 est en commentaire pour ne pas dédoubler le travail avec 4.1
                // note = q4_lireResultat();

                if (note >= 0)
                {
                    nbEleve++;
                    moyenne += note;
                }

                if (note < 60 && note >= 0)
                {
                    echec++;
                }
            }

            moyenne = moyenne / nbEleve;

            Console.Clear(); // pas obligatoire, c'est pour faire moins laid
            Console.WriteLine("Nombre d'élèves : " + nbEleve);
            Console.WriteLine("Moyenne du groupe : " + moyenne);
            Console.WriteLine("Nombre d'échecs : " + echec);
        }

        static int q4_lireResultat()
        {
            int note = 0;
            bool valide = false;

            while (!valide)
            {
                Console.WriteLine("Prochain résultat : ");
                int.TryParse(Console.ReadLine(), out note);
                if (note >= 0 && note <= 100)
                {
                    valide = true;
                }
                else if (note < 0)
                {
                    valide = true;
                }
                else
                {
                    Console.WriteLine("La note n'est pas valide!");
                }
            }

            return note;
        }

        static void q1(int nombre)
        {
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine(nombre + " x " + i + " = " + nombre * i);
            }
        }

        static void q2(int nombreMax)
        {
            for (int i = 1; i <= nombreMax; i++)
            {
                q1(i);
            }
        }

        static double q31(double[] tabPrixEssence)
        {
            double moyenne = 0.0;

            for (int i = 0; i < tabPrixEssence.Length; i++)
            { 
                moyenne += tabPrixEssence[i];
            }

            moyenne = moyenne / tabPrixEssence.Length;

            return moyenne;
        }

        static int q32(double[] tabPrixEssence)
        {
            int nbFois = 0;

            for (int i = 0; i < tabPrixEssence.Length; i++)
            {
                if (tabPrixEssence[i] < q31(tabPrixEssence))
                {
                    nbFois++;
                }
            }
            
            return nbFois;
        }
    }
}